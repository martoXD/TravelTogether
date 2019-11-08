using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TravelTogether.Data;
using TravelTogether.Models;
using TravelTogether.ViewModels.Posts;

namespace TravelTogether.Controllers
{
    public class PostsController : Controller
    {
        private readonly SignInManager<TtUser> signInManager;
        private readonly ApplicationDbContext dbContext;

        public PostsController(
            SignInManager<TtUser> signInManager,
            ApplicationDbContext dbContext)
        {
            this.signInManager = signInManager;
            this.dbContext = dbContext;
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(CreatePostViewModel inputModel)
        {
            var user = this.signInManager.UserManager.Users
               .FirstOrDefault(u => u.Id == inputModel.UserId);

            if (inputModel.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                inputModel.Image.OpenReadStream().CopyTo(ms);

                var post = new Post
                {
                    Caption = inputModel.Caption,
                    TtUser = user,
                    TtUserId = user.Id,
                    CreatedOn = DateTime.UtcNow
                };

                var image = new Image()
                {
                    ImageContent = ms.ToArray(),
                    Post = post,
                    PostId = post.Id
                };
                string imageBase64 = Convert.ToBase64String(image.ImageContent);
                string imageSrc = string.Format("data:image/gif;base64,{0}", imageBase64);
                image.ImageSource = imageSrc;

                post.Image = image;
                post.ImageId = image.Id;

                user.Posts.Add(post);
                this.dbContext.Posts.Add(post);
                //this.dbContext.Images.Add(image);

                this.dbContext.Entry(user).State = EntityState.Modified;
            }
            this.dbContext.Update(user);
            this.dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddComment(string comment_data, int? post_Id, string user_Id)
        {
            var post = this.dbContext.Posts.FirstOrDefault(p => p.Id == post_Id);
            var user = this.dbContext.Users.FirstOrDefault(u => u.Id == user_Id);
            Comment comment = null;

            if (ModelState.IsValid)
            {
                if (comment_data != null && post_Id != null && user_Id != null)
                {
                    comment = new Comment
                    {
                        CommentContent = comment_data,
                        Post = post,
                        PostId = post.Id,
                        Sender = user,
                        SenderId = user.Id
                    };
                    user.Comments.Add(comment);
                    post.Comments.Add(comment);
                    await this.dbContext.Comments.AddAsync(comment);

                    await this.dbContext.SaveChangesAsync();
                }
            }
            var userProfileImgSrc = user.ProfileImageSrc;
            var defaultImgSrc = user.DefaultImageSrc;
            var userFirstName = user.FirstName;
            var userLastName = user.LastName;
            var commentContent = comment.CommentContent;
            var postCommentsNum = post.Comments.Count();
            var postId = post.Id;

            var serializedPost = JsonConvert.SerializeObject(
                                 new
                                 {                                  
                                     UserProfileImgSrc = userProfileImgSrc,
                                     DefaultImgSrc = defaultImgSrc,
                                     UserFirstName = userFirstName,
                                     UserLastName = userLastName,
                                     CommentContent = commentContent,
                                     PostCommentsNum = postCommentsNum,
                                     PostId = postId
                                 },
                                 Formatting.Indented,
                                 new JsonSerializerSettings
                                 {
                                     PreserveReferencesHandling = PreserveReferencesHandling.Objects
                                 });
            return Json(serializedPost);
            //return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [Authorize]
        public IActionResult Like(int? post_Id, string user_Id)
        {
            var post = this.dbContext.Posts.FirstOrDefault(p => p.Id == post_Id);
            var user = (TtUser)this.dbContext.Users.FirstOrDefault(u => u.Id == user_Id);
            var like = new Like();

            if (ModelState.IsValid)
            {
                if (post_Id != null && user_Id != null)
                {
                    like = new Like
                    {
                        PostId = post.Id,
                        Post = post,
                        TtUserId = user.Id,
                        TtUser = user
                    };
                    user.Likes.Add(like);
                    post.Likes.Add(like);

                    this.dbContext.Likes.Add(like);

                    this.dbContext.Update(post);
                    this.dbContext.Update(user);

                    this.dbContext.SaveChanges();
                }
            }
            var postId = post.Id;
            var postLikes = post.Likes.Count;
            var userId = user.Id;
            var likeId = like.Id;

            var serializedPost = JsonConvert.SerializeObject(
                                new
                                {
                                    PostId = postId,
                                    PostLikes = postLikes,
                                    UserId = userId,
                                    LikeId = likeId
                                },
                                Formatting.Indented,
                                new JsonSerializerSettings
                                {
                                    PreserveReferencesHandling = PreserveReferencesHandling.Objects
                                });
            return Json(serializedPost);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Dislike(int? post_Id, string user_Id, int? like_Id)
        {
            var post = this.dbContext.Posts.FirstOrDefault(p => p.Id == post_Id);
            var user = this.dbContext.Users.FirstOrDefault(u => u.Id == user_Id);

            if (ModelState.IsValid)
            {
                if (post_Id != null && user_Id != null && like_Id != null)
                {
                    var like = this.dbContext.Likes.FirstOrDefault(l => l.Id == like_Id);

                    user.Likes.Remove(like);
                    post.Likes.Remove(like);

                    this.dbContext.Likes.Remove(like);

                    this.dbContext.Update(post);
                    this.dbContext.Update(user);

                    this.dbContext.SaveChanges();
                }
            }
            var postId = post.Id;
            var userId = user.Id;
            var postLikes = post.Likes.Count;

            var serializedPost = JsonConvert.SerializeObject(
                                new
                                {
                                    PostId = postId,
                                    PostLikes = postLikes,
                                    UserId = userId,
                                },
                                Formatting.Indented,
                                new JsonSerializerSettings
                                {
                                    PreserveReferencesHandling = PreserveReferencesHandling.Objects
                                });
            return Json(serializedPost);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week01.Models.Request;
using Week01.Services;

namespace Week01.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly ISessionService _sessionService;

        public PostController(IPostService postService, ISessionService sessionService)
        {
            _postService = postService;
            _sessionService = sessionService;
        }

        // GET: Post
        public async Task<IActionResult> Index()
        {
            var posts = await _postService.ListPostAsync();
            return View(posts);
        }

        // GET: Post/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var post = await _postService.GetPostAsync(id);
            
            return View(post);
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PostPostModel model)
        {
            try
            {
                var post = await _postService.CreatePostAsync(await _sessionService.GetUserAsync(), model.Title, model.Content, model.Password);

                return RedirectToAction("Details", new {id = post.Id});
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Post/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Post/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
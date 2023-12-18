using ProductAccountingInStockDatabase.DatabaseModels;
using ProductAccountingInStockDatabase.StoragesContracts;
using ProductAccountingInStockModels.BindingModels;
using ProductAccountingInStockModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductAccountingInStockDatabase.Implements
{
    public class PostStorage : IPostStorage
    {
        public List<PostViewModel> GetFullList()
        {
            using var context = new ProductAccountingInStockDatabase();
            return context.Posts
            .Select(CreateModel)
            .ToList();
        }
        public PostViewModel GetElement(PostBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new ProductAccountingInStockDatabase();
            var post = context.Posts
            .FirstOrDefault(rec => rec.PostName == model.PostName || rec.Id == model.Id);
            return post != null ? CreateModel(post) : null;
        }
        public void Insert(PostBindingModel model)
        {
            using var context = new ProductAccountingInStockDatabase();
            context.Posts.Add(CreateModel(model, new Post()));
            context.SaveChanges();
        }
        public void Delete(PostBindingModel model)
        {
            using var context = new ProductAccountingInStockDatabase();
            Post post = context.Posts.FirstOrDefault(rec => rec.Id == model.Id);
            if (post != null)
            {
                context.Posts.Remove(post);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Должность не найдена");
            }
        }
        private static Post CreateModel(PostBindingModel model, Post post)
        {
            post.PostName = model.PostName;
            return post;
        }
        private static PostViewModel CreateModel(Post post)
        {
            return new PostViewModel
            {
                Id = post.Id,
                PostName = post.PostName
            };
        }
    }
}

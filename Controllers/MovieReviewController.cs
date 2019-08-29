using ASPApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPApplication.Controllers
{
    public class MovieReviewController : Controller
    {

        static List<MovieReviews> _movieReviews = new List<MovieReviews>
        {
            new MovieReviews
            {
                Id=1,
                MovieName="Avatar",
                ReviewerName="Rahul Sahay",
                ReviewerComments="Excellent",
                ReviewerRatings=5
            },
             new MovieReviews
            {
                Id=2,
                MovieName="Titanic",
                ReviewerName="Rahul Sahay",
                ReviewerComments="Excellent",
                ReviewerRatings=5
            },
              new MovieReviews
            {
                Id=3,
                MovieName="Mission Mangal",
                ReviewerName="Rahul Sahay",
                ReviewerComments="Excellent",
                ReviewerRatings=5
            },
               new MovieReviews
            {
                Id=4,
                MovieName="KGF",
                ReviewerName="Rahul Sahay",
                ReviewerComments="Excellent",
                ReviewerRatings=5
            },
                new MovieReviews
            {
                Id=5,
                MovieName="Sahoo",
                ReviewerName="Rahul Sahay",
                ReviewerComments="Excellent",
                ReviewerRatings=5
            },
        };
        // GET: MovieReview
        public ActionResult Index()
        {
            return View(_movieReviews);
        }

        // GET: MovieReview/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieReview/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieReview/Create
        [HttpPost]
        public ActionResult Create(MovieReviews mr)//the parameter is the collection of data created by user
        {
            try
            {
                // TODO: Add insert logic here
                _movieReviews.Add(mr);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieReview/Edit/5
        public ActionResult Edit(int id)
        {
            var movieReviewObj = _movieReviews.Where(obj => obj.Id == id).FirstOrDefault();
            return View(movieReviewObj);
        }

        // POST: MovieReview/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MovieReviews updatedMovieReview)
        {
            try
            {
                // TODO: Add update logic here
                //var movieReviewToBeUpdated = (from MovieReviews in_movieReviews
                //                            where MovieReviews.Id==id
                //                              select movieReview).Single();//OR 
                var movieReviewObj = _movieReviews.Where(obj => obj.Id == id).FirstOrDefault();

                movieReviewObj.MovieName = updatedMovieReview.MovieName;
                movieReviewObj.ReviewerName = updatedMovieReview.ReviewerName;
                movieReviewObj.ReviewerComments = updatedMovieReview.ReviewerComments;
                movieReviewObj.ReviewerRatings = updatedMovieReview.ReviewerRatings;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieReview/Delete/5
        public ActionResult Delete(int id)
        {
            var movieReviewObj = _movieReviews.Where(obj => obj.Id == id).FirstOrDefault();
            return View(movieReviewObj);
        }

        // POST: MovieReview/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, MovieReviews deletedMovieReviews)
        {
            try
            {
                // TODO: Add delete logic here
                var MovieReviewToBeDeleted = _movieReviews.Find(s => s.Id == id);
                _movieReviews.Remove(MovieReviewToBeDeleted);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

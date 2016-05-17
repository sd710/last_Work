﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;
using GameStore.WebUI.Models;
using GameStore.WebUI.Controllers;

namespace GameStore.WebUI.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        private IGameRepository repository;

        public int pageSize = 4; // количество моделей на странице

        public GameController(IGameRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string category, int page = 1)
        {
            GamesListViewModel model = new GamesListViewModel
            {
                Games = repository.Games
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(game => game.GameId)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = category == null ?
                repository.Games.Count() :
                repository.Games.Where(game => game.Category == category).Count()
                },
                CurrentCategory = category
                
            };
            return View(model);
        }
    }
}
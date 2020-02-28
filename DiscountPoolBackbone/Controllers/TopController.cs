using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DiscountPoolBackbone.Models;
using DiscountPoolBackbone.Models.TOP;
using DiscountPoolBackbone.Models.Pagination;
using DiscountPoolBackbone.Helpers.Pagination;

namespace DiscountPoolBackbone.Controllers
{
    public class TopController : Controller
    {
        private readonly DiscountsContext _context;

        public TopController(DiscountsContext context)
        {
            _context = context;
        }

        // GET: Top
        public async Task<IActionResult> Index()
        {
            return View(await _context.TopItems.ToListAsync());
        }

        public async Task<IActionResult> Index2(int page = 1)
        {
            int pageSize = 9;
            IQueryable<TopItem> source = _context.TopItems;
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            PaginatedTopModel viewModel = new PaginatedTopModel
            {
                PageViewModel = pageViewModel,
                TopItems = items
            };

            return View(viewModel);
        }

        // GET: Top/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topItem = await _context.TopItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (topItem == null)
            {
                return NotFound();
            }

            return View(topItem);
        }

        // GET: Top/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Top/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PopularRate,Type,Name,ShorDescription,Description,Author,LocalPrice,WorldPrice,SmallPhotoId,MainPhotoId,PhotosIds,LikedUsersIds,IsActive,IsVIP,VipExpirationDate,TotalSum,InstagramUrl,InstagramLikesCount,FacebookUrl,FacebookLikesCount,VkUrl,VkLikesCount,PinterestUrl,PinterestLikesCount,MediumUrl,MediumLikesCount,AmazonUrl,AmazonLikesCount,AmazonPrice,EbayUrl,EbayLikesCount,EbayPrice,AvitoUrl,AvitoLikesCount,AvitoPrice,OlxUrl,OlxLikesCount,OlxPrice,KufarUrl,KufarLikesCount,KufarPrice,OnlinerUrl,OnlinerLikesCount,OnlinerPrice,vek21Url,vek21LikesCount,vek21Price,IsAdultContent")] TopItem topItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(topItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(topItem);
        }

        // GET: Top/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topItem = await _context.TopItems.FindAsync(id);
            if (topItem == null)
            {
                return NotFound();
            }
            return View(topItem);
        }

        // POST: Top/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PopularRate,Type,Name,ShorDescription,Description,Author,LocalPrice,WorldPrice,SmallPhotoId,MainPhotoId,PhotosIds,LikedUsersIds,IsActive,IsVIP,VipExpirationDate,TotalSum,InstagramUrl,InstagramLikesCount,FacebookUrl,FacebookLikesCount,VkUrl,VkLikesCount,PinterestUrl,PinterestLikesCount,MediumUrl,MediumLikesCount,AmazonUrl,AmazonLikesCount,AmazonPrice,EbayUrl,EbayLikesCount,EbayPrice,AvitoUrl,AvitoLikesCount,AvitoPrice,OlxUrl,OlxLikesCount,OlxPrice,KufarUrl,KufarLikesCount,KufarPrice,OnlinerUrl,OnlinerLikesCount,OnlinerPrice,vek21Url,vek21LikesCount,vek21Price,IsAdultContent")] TopItem topItem)
        {
            if (id != topItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(topItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TopItemExists(topItem.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(topItem);
        }

        // GET: Top/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topItem = await _context.TopItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (topItem == null)
            {
                return NotFound();
            }

            return View(topItem);
        }

        // POST: Top/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var topItem = await _context.TopItems.FindAsync(id);
            _context.TopItems.Remove(topItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TopItemExists(int id)
        {
            return _context.TopItems.Any(e => e.Id == id);
        }
    }
}

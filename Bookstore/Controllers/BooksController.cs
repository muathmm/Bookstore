﻿using Bookstore.data;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bookstore.Controllers
{
    public class BooksController : Controller
    {
     
            private readonly LibraryContext _context;

            public BooksController(LibraryContext context)
            {
                _context = context;
            }

            // GET: Books
            public async Task<IActionResult> Index()
            {
                var books = from b in _context.Books
                            select b;


                return View(await books.ToListAsync());
            }

            // GET: Books/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var book = await _context.Books
                    .FirstOrDefaultAsync(m => m.BookId == id);
                if (book == null)
                {
                    return NotFound();
                }

                return View(book);
            }

            // GET: Books/Create
            public IActionResult Create()
            {
                return View();
            }

            // POST: Books/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("Id,Title,Author,Price,Genre")] Book book)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(book);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(book);
            }

            // GET: Books/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var book = await _context.Books.FindAsync(id);
                if (book == null)
                {
                    return NotFound();
                }
                return View(book);
            }

            // POST: Books/Edit/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Author,Price,Genre")] Book book)
            {
                if (id != book.BookId)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(book);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!BookExists(book.BookId))
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
                return View(book);
            }

            // GET: Books/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var book = await _context.Books
                    .FirstOrDefaultAsync(m => m.BookId == id);
                if (book == null)
                {
                    return NotFound();
                }

                return View(book);
            }

            // POST: Books/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var book = await _context.Books.FindAsync(id);
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool BookExists(int id)
            {
                return _context.Books.Any(e => e.BookId == id);
            }
        }
    }

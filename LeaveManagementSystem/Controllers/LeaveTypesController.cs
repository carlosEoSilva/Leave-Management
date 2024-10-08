﻿using LeaveManagementSystem.Common;
using LeaveManagementSystem.Models.LeaveTypes;
using LeaveManagementSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class LeaveTypesController(ILeaveTypesService _leaveTypeService) : Controller
    {
        private const string NameExistsValidationMessage = "Leave type name already exists";

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            var viewData = await _leaveTypeService.GetAll();
            return View(viewData);
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var leaveType = await _leaveTypeService.Get<LeaveTypeReadOnlyVM>(id.Value);

            if (leaveType == null)
                return NotFound();

            return View(leaveType);
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeCreateVM leaveTypeCreate)
        {
            //note-9
            if (await _leaveTypeService.CheckIfLeaveTypeNameExists(leaveTypeCreate.Name))
                ModelState.AddModelError(nameof(leaveTypeCreate.Name), NameExistsValidationMessage);

            if (ModelState.IsValid)
            {
                await _leaveTypeService.Create(leaveTypeCreate);
                return RedirectToAction(nameof(Index));
            }

            return View(leaveTypeCreate);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var leaveType = await _leaveTypeService.Get<LeaveTypeEditVM>(id.Value);

            if (leaveType == null)
                return NotFound();

            return View(leaveType);
        }

        // POST: LeaveTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeEditVM leaveTypeEdit)
        {
            if (id != leaveTypeEdit.Id)
                return NotFound();

            if (await _leaveTypeService.CheckIfLeaveTypeNameExistsForEdit(leaveTypeEdit))
                ModelState.AddModelError(nameof(leaveTypeEdit.Name), NameExistsValidationMessage);

            if (ModelState.IsValid)
            {
                try
                {
                    await _leaveTypeService.Edit(leaveTypeEdit);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_leaveTypeService.LeaveTypeExists(leaveTypeEdit.Id))
                        return NotFound();

                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }

            return View(leaveTypeEdit);
        }

        // GET: LeaveTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var leaveType = await _leaveTypeService.Get<LeaveTypeReadOnlyVM>(id.Value);

            if (leaveType == null)
                return NotFound();

            return View(leaveType);
        }

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leaveType = await _leaveTypeService.Get<LeaveTypeReadOnlyVM>(id);

            if (leaveType != null)
                await _leaveTypeService.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}

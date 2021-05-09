using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    
    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor myVendor = new Vendor(name, description);
      return RedirectToAction("Index");
    }
  }
}
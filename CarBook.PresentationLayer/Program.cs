using CarBook.BusinessLayer.Abstract;
using CarBook.BusinessLayer.Concrete;
using CarBook.DataAccessLayer.Abstract;
using CarBook.DataAccessLayer.Concrete;
using CarBook.DataAccessLayer.EntityFramework;
using CarBook.EntityLayer.Concrete;
using CarBook.PresentationLayer.Models;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CarBookContext>();

builder.Services.AddScoped<IBrandDal, EfBrandDal>();
builder.Services.AddScoped<IBrandService,BrandManager>();

builder.Services.AddScoped<ICarStatusDal, EfCarStatusDal>();
builder.Services.AddScoped<ICarStatusService, CarStatusManager>();

builder.Services.AddScoped<ICarDal, EfCarDal>();
builder.Services.AddScoped<ICarService, CarManager>();

builder.Services.AddScoped<IPriceDal, EfPriceDal>();
builder.Services.AddScoped<IPriceService, PriceManager>();

builder.Services.AddScoped<IServiceDal, EfServiceDal>();
builder.Services.AddScoped<IServiceService, ServiceManager>();

builder.Services.AddScoped<IHowItWorksStepDal, EfHowItWorksStepDal>();
builder.Services.AddScoped<IHowItWorksStepService, HowItWorksStepManager>();

builder.Services.AddScoped<ICarCategoryDal, EfCarCategoryDal>();
builder.Services.AddScoped<ICarCategoryService, CarCategoryManager>();

builder.Services.AddScoped<ICarDetailDal, EfCarDetailDal>();
builder.Services.AddScoped<ICarDetailService, CarDetailManager>();

builder.Services.AddScoped<ICommentDal, EfCommentDal>();
builder.Services.AddScoped<ICommentService, CommentManager>();

builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

builder.Services.AddScoped<ICompanyDal, EfCompanyDal>();
builder.Services.AddScoped<ICompanyService, CompanyManager>();

builder.Services.AddScoped<ITeamDal, EfTeamDal>();
builder.Services.AddScoped<ITeamService, TeamManager>();

builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IContactService, ContactManager>();

builder.Services.AddScoped<IContactInfoDal, EfContactInfoDal>();
builder.Services.AddScoped<IContactInfoService, ContactInfoManager>();

builder.Services.AddScoped<ICarRantDal, EfCarRantDal>();
builder.Services.AddScoped<ICarRantService, CarRantManager>();

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<CarBookContext>().AddErrorDescriber<CustomIdentityValidator>();

builder.Services.AddControllersWithViews().AddFluentValidation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

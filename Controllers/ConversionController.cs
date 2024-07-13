using System.Diagnostics;
using ConversionMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ConversionMVC.Controllers;

//[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class ConversionController: Controller
 {


     public IActionResult ConversionHomePage()
    {
        return View();
    }
    [HttpPost]
    public IActionResult ConversionHomePage(Conversion t)
    {
        if(t.Type=="Currency")
        return RedirectToAction("Currency");

        else if(t.Type=="Length")
        return RedirectToAction("Length");

        else if(t.Type=="Temperature")
        return RedirectToAction("Temperature");

        if(t.Type=="Weight")
        return RedirectToAction("Weight");


        return View();
    }
   

      public IActionResult Currency()
    {
        Conversion c=new Conversion();
        return View(c);
    }
    [HttpPost]
    public async Task<IActionResult> Currency(Conversion a)
    {

        
                var client = new HttpClient();
                var request = new HttpRequestMessage
            {
	                    Method = HttpMethod.Get,
	                    RequestUri = new Uri("https://currency-converter-by-api-ninjas.p.rapidapi.com/v1/convertcurrency?have="+a.FromUnit+"&want="+a.ToUnit+"&amount="+a.Value),
	                    Headers =
	                {
		                { "X-RapidAPI-Key", "590f802770msh84b0e0f2c5190c4p15c5b9jsn2885a4803ad0" },
		                { "X-RapidAPI-Host", "currency-converter-by-api-ninjas.p.rapidapi.com" },
	                },
            };
                    using (var response = await client.SendAsync(request))
                    {
	                    response.EnsureSuccessStatusCode();
	                    var body = await response.Content.ReadAsStringAsync();
	                    //Console.WriteLine(body);
                        var result=JsonConvert.DeserializeObject<Conversion>(body);
                        return View("Currency",result);

                    }
    }

     public IActionResult Length()
    {
        Conversion c = new Conversion();
        return View(c);
    }


    [HttpPost]
     public IActionResult Length(Conversion a)   
          {  
            switch(a.FromUnit)
          {
            case "cm":
                      switch(a.ToUnit)
                       {
                          case "cm":                    
                                    return View("Length",a);
                          case "m": 
                                    a.Value=a.Value/100;
                                    return View("Length",a);
                          case "in":
                                    a.Value=a.Value*39.37008;
                                     return View("Length",a);
                          case "ft":
                                   a.Value=a.Value*0.0328084;
                                   return View("Length",a);
                       }
                       break;
            case "m":
             switch(a.ToUnit)
                       {
                          case "cm":
                                   a.Value=a.Value*100;
                                    return View("Length",a);
                          case "m": 
                                   
                                     return View("Length",a);
                          case "in":
                                    a.Value=a.Value*39.3701;
                                      return View("Length",a);
                          case "ft":
                                    a.Value=a.Value*3.28084;
                                    return View("Length",a);
                       }
                       break;
            case "in":
             switch(a.ToUnit)
                       {
                          case "cm":
                                    a.Value=a.Value*2.54;
                                    return View("Length",a);
                          case "m": 
                                    a.Value=a.Value*0.0254;
                                    return View("Length",a);
                          case "in":
                                   
                                    return View("Length",a);
                          case "ft":
                                    a.Value=a.Value/0.083333;
                                    return View("Length",a);
                       }
                       break;
            case "ft":
            switch(a.ToUnit)
                       {
                          case "cm":
                                   a.Value=a.Value*30.48;
                                    return View("Length",a);
                          case "m": 
                                    a.Value=a.Value*0.3048;
                                    return View("Length",a);
                          case "in":
                                   a.Value=a.Value*12;
                                     return View("Length",a);
                          case "ft":
                                     
                                    return View("Length",a);
                       }
                       
                     break;
          }
            return View("Length");
          }

     public IActionResult Temperature()
    {
      Conversion c=new Conversion();
        return View(c);
    }

    [HttpPost]
    public IActionResult Temperature (Conversion a)
    {  
        switch(a.FromUnit)
          {
            case "dc":    //degree celsius
                      switch(a.ToUnit)
                       {
                          case "dc":                    
                                    return View("Temperature",a);
                          case "fer": 
                                    a.Value=a.Value*33.8;
                                    return View("Temperature",a);
                          case "kal":
                                    a.Value=a.Value*274.15;
                                     return View("Temperature",a);
                          
                       }
                       break;


                       case "fer":
                                  switch(a.ToUnit)
                                  {
                                        case "dc":
                                        a.Value=a.Value*(-17.2222);
                                        return View("Temperature",a);
                              case "fer": 
                                   
                                     return View("Temperature",a);
                              case "kal":
                                      a.Value=a.Value*255.9278;
                                      return View("Temperature",a);
                              
                       }
                       break;

                       case "kal":
                                  switch(a.ToUnit)
                                  {
                                        case "dc":
                                        a.Value=a.Value*(-272.14996);
                                        return View("Temperature",a);
                              case "kal": 
                                   
                                     return View("Temperature",a);
                              case "fer":
                                      a.Value=a.Value*-457.869928;
                                      return View("Temperature",a);
                             
                       }
                       break;

          }
          return View("Temperature");

    }







     public IActionResult Weight()
    {
      Conversion c = new Conversion();
        return View(c);
    }

    //  public IActionResult Weight (Conversion a)
    // {
    //   if(a.FromUnit == "kg")
    //   {
    //         if(a.ToUnit=="kg")
    //          {
    //             a.Value=a.Value;
    //             return View ("weight",a);

    //          }

    //           else if(a.ToUnit=="OZ")
    //          {
    //             a.Value=a.Value;
    //             return View ("weight",a);

    //          }
    //           if(a.ToUnit=="lbs")
    //          {
    //             a.Value=a.Value;
    //             return View ("weight",a);

    //          }
    //   }

    [HttpPost]
    public IActionResult Weight (Conversion a)
    {  
        switch(a.FromUnit)
          {
            case "kg":
                      switch(a.ToUnit)
                       {
                          case "kg":                    
                                    return View("Weight",a);
                          case "g": 
                                    a.Value=a.Value*1000;
                                    return View("Weight",a);
                          case "pound":
                                    a.Value=a.Value*2.20462;
                                     return View("Weight",a);
                          case "ounce":
                                   a.Value=a.Value*35.274;
                                   return View("Weight",a);
                       }
                       break;

                        case "g":
                                  switch(a.ToUnit)
                                  {
                                        case "kg":
                                        a.Value=a.Value*0.001;
                                        return View("Weight",a);
                              case "g": 
                                   
                                     return View("Weight",a);
                              case "pounds":
                                      a.Value=a.Value*0.00220462;
                                      return View("Weight",a);
                              case "ounch":
                                    a.Value=a.Value*0.035274;
                                    return View("Weight",a);
                       }
                       break;

                       case "pounds":
                                  switch(a.ToUnit)
                                  {
                                        case "kg":
                                        a.Value=a.Value*0.45359285929009;
                                        return View("Weight",a);
                              case "pounds": 
                                   
                                     return View("Weight",a);
                              case "g":
                                      a.Value=a.Value*453.59285929009001848;
                                      return View("Weight",a);
                              case "ounch":
                                    a.Value=a.Value*16.000017259200017605;
                                    return View("Weight",a);
                       }
                       break;


                       case "ounch":
                                  switch(a.ToUnit)
                                  {
                                        case "kg":
                                        a.Value=a.Value*0.028349553705630626405;
                                        return View("Weight",a);
                              case "ounch": 
                                   
                                     return View("Weight",a);
                              case "g":
                                      a.Value=a.Value*28.349553705630626155;
                                      return View("Weight",a);
                              case "pounds":
                                    a.Value=a.Value*0.062500067418750068771;
                                    return View("Weight",a);
                       }
                       break;
                       
          }
          return View("Weight");
    }





}
 


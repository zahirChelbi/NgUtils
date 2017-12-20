using System;
using System.Collections.Generic;
using System.Linq;
namespace NgUtils.Utils
{
    class UClientApp
    {
        // Creation des Composants
        public static string componentContent(string name)
        {
            return
$@"import {{ Component }} from '@angular/core';

@Component({{
    selector: '{name}',
    templateUrl: './{name}.component.html',
    styleUrls: ['./{name}.component.css']
}})
export class {getModuleName(name)}Component {{
    public name:string ;
    constructor() {{
           this.name =""{name}""
    }}
}}";

        }
        public static string componentTemplate(string name)
        {
            if (name.ToLower().Equals("app"))
            {
                return
$@"<navmenu></navmenu>
<div class=""container body-content"">
    <router-outlet></router-outlet>
</div>";
            } else if (name.ToLower().Equals("navmenu"))
            {
                return
$@"<nav class=""navbar navbar-default navbar-fixed-top"">
    <div class=""container"">
        <div class=""navbar-header"">
            <button type = ""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target=""#myNavbar"">
                <span class=""icon-bar""></span>
                <span class=""icon-bar""></span>
                <span class=""icon-bar""></span>
            </button>
            <a class=""navbar-brand  navbar-brand-left"" [routerLink]=""['home']"">App</a>
        </div>
        <div class=""collapse navbar-collapse"" id=""myNavbar"">
            <ul class=""nav navbar-nav navbar-right"">
                <li [routerLinkActive]=""['link-active']""><a [routerLink]=""['/about']""><span class=""fa fa-users sr-only""></span>About</a></li>
                <li [routerLinkActive]=""['link-active']""><a [routerLink]=""['/blog']""><span class=""fa fa-users sr-only""></span>Blog</a></li>
                <li [routerLinkActive]=""['link-active']""><a [routerLink]=""['/home']""><span class=""glyphicon glyphicon-duplicate sr-only""></span>Home</a></li>
            </ul>
        </div>
    </div>
</nav>";

            } else {
                return 
$@"<div class=""row"">
    <div class=""col-md-6 col-xs-12"">
        <div class=""jumbotron text-center"">
            <h1>{name}</h1>
        </div>
    </div>
</div>";
            }
        }
        public static string componentStyle(string name)
        {
            if (name.ToLower().Equals("app"))
            {
                return
$@".container.body-content {{
    margin-top: 60px;
}}";
            }
            else if (name.ToLower().Equals("navmenu"))
            {
                return
$@".navbar {{
    margin-bottom: 0;
    background-color: #1abc9c;
    z-index: 9999;
    border: 0;
    font-size: 12px !important;
    line-height: 1.42857143 !important;
    letter-spacing: 4px;
    border-radius: 0;
}}

.navbar li a, .navbar .navbar-brand {{
    color: #fff !important;
}}

.navbar-nav li a:hover, .navbar-nav li.active a {{
    color: #1abc9c !important;
    background-color: #fff !important;
}}

.navbar-default .navbar-toggle {{
    border-color: transparent;
    color: #fff !important;
}}

.navbar-brand-left {{
    position: absolute;
    display: block;
    width: 160px;
    text-align: center;
    background-color: transparent;
}}
.navbar>.container .navbar-brand-left, 
.navbar>.container-fluid .navbar-brand-left {{
    margin-left: 0px;
}}";

            }else{
                return $@"body{{}}";
            }

        }

        public static string moduleContent(string name)
        {
            return
$@"import {{ NgModule }} from '@angular/core';

import {{ {getModuleName(name)}Component }} from './{name}.component';
import {{ routing }} from './{name}.routing';

@NgModule({{
    imports: [routing  ],
    declarations: [{getModuleName(name)}Component]
}})
export class {getModuleName(name)}Module {{ }}";
        }

        public static string routingContent(string name)
        {
            return
$@"import {{ ModuleWithProviders }} from '@angular/core';
import {{ Routes,RouterModule }} from '@angular/router';

import {{ {getModuleName(name)}Component }} from './{name}.component';

const routes: Routes = [
    {{ path: '', component: {getModuleName(name)}Component }}
];

export const routing: ModuleWithProviders = RouterModule.forChild(routes);";
        }





        public static string serviceContent(string name)
        {
            return
$@"
import {{ Injectable }} from '@angular/core';
import {{ Http }} from '@angular/http';

@Injectable()
export class {getModuleName(name)}Service {{
    constructor(private http: Http) {{

    }}
    getList() {{
        return this.http.get('http://localhost:8080/api/List');
    }}

}}";

        }
        public static string pipeContent(string name)
        {
            return
$@"import {{Pipe,PipeTransform}} from '@angular/core';
 
@Pipe({{name: '{name}'}})
export class {getModuleName(name)}Pipe implements PipeTransform {{
    transform(value: number, args: string[]): any {{
        return (value * 10 / 2.6 ) * 2 - parseInt(args[0] || '1', 10) / 3;
    }}
}}";
        }
        public static string directiveContent(string name)
        {
            return
$@"import {{Directive,Renderer2, ElementRef}} from '@angular/core';

@Directive({{
  selector: '[{name}]'
}})
export class {getModuleName(name)}Directive {{

  constructor(el: ElementRef, renderer: Renderer2) {{
    renderer.setStyle(el.nativeElement, 'color', 'red');
  }}

}}";

        }



        public static string getModuleName(string name)
        {
            string m = null;
            if (name == null)
                return m;
            if (name.Length > 1)
            {
                m = char.ToUpper(name[0]) + name.Substring(1);
            }
            else
            {
                m = name.ToUpper();
            }
            return m;
        }
    }
}

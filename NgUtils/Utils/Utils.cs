
using System;

namespace ngUtils.Utils
{
    public static class Utils
    {
        //config
        public static string envprod()
        {
            return
@"export const environment = {
  production: true
};";
        }
        public static string env()
        {
            return
@"export const environment = {
  production: false
};";
        }
        public static string index()
        {
            return
$@"<!doctype html>
<html lang='en'>
<head>
  <meta charset = 'utf-8' >
  <title> Mon </title>
  <base href = '/'>
  <meta name = 'viewport' content = 'width=device-width, initial-scale=1' >
  <link rel = 'icon' type = 'image/x-icon' href = 'favicon.ico' >
  <link href = 'https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css' rel = 'stylesheet' />
  <script src = 'https://code.jquery.com/jquery-3.2.1.min.js' crossorigin = 'anonymous'></script>
  <script src = 'https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js' ></script>
</head>
<body>
    <app></app>
</body>
</html>";
        }

        public static string polyfills()
        {
            return
@"
/**
 * This file includes polyfills needed by Angular and is loaded before the app.
 * You can add your own extra polyfills to this file.
 *
 * This file is divided into 2 sections:
 *   1. Browser polyfills. These are applied before loading ZoneJS and are sorted by browsers.
 *   2. Application imports. Files imported after ZoneJS that should be loaded before your main
 *      file.
 *
 * The current setup is for so-called 'evergreen' browsers; the last versions of browsers that
 * automatically update themselves. This includes Safari >= 10, Chrome >= 55 (including Opera),
 * Edge >= 13 on the desktop, and iOS 10 and Chrome on mobile.
 *
 * Learn more in https://angular.io/docs/ts/latest/guide/browser-support.html
 */

/***************************************************************************************************
 * BROWSER POLYFILLS
 */

/** IE9, IE10 and IE11 requires all of the following polyfills. **/
// import 'core-js/es6/symbol';
// import 'core-js/es6/object';
// import 'core-js/es6/function';
// import 'core-js/es6/parse-int';
// import 'core-js/es6/parse-float';
// import 'core-js/es6/number';
// import 'core-js/es6/math';
// import 'core-js/es6/string';
// import 'core-js/es6/date';
// import 'core-js/es6/array';
// import 'core-js/es6/regexp';
// import 'core-js/es6/map';
// import 'core-js/es6/weak-map';
// import 'core-js/es6/set';

/** IE10 and IE11 requires the following for NgClass support on SVG elements */
// import 'classlist.js';  // Run `npm install --save classlist.js`.

/** IE10 and IE11 requires the following for the Reflect API. */
// import 'core-js/es6/reflect';


/** Evergreen browsers require these. **/
// Used for reflect-metadata in JIT. If you use AOT (and only Angular decorators), you can remove.
import 'core-js/es7/reflect';


/**
 * Required to support Web Animations `@angular/platform-browser/animations`.
 * Needed for: All but Chrome, Firefox and Opera. http://caniuse.com/#feat=web-animation
 **/
// import 'web-animations-js';  // Run `npm install --save web-animations-js`.



/***************************************************************************************************
 * Zone JS is required by Angular itself.
 */
import 'zone.js/dist/zone';  // Included with Angular CLI.



/***************************************************************************************************
 * APPLICATION IMPORTS
 */

/**
 * Date, currency, decimal and percent pipes.
 * Needed for: All but Chrome, Firefox, Edge, IE11 and Safari 10
 */
// import 'intl';  // Run `npm install --save intl`.
/**
 * Need to import at least one locale-data with intl.
 */
// import 'intl/locale-data/jsonp/en';

";
        }
        public static string stylecss()
        {
            return
 @"";
        }

        public static string typing()
        {
            return @"
/* SystemJS module definition */
declare var module: NodeModule;
interface NodeModule {
  id: string;
}
";
        }

        //app
        public static string appmodule()
        {
            return
$@"import {{ BrowserModule }} from '@angular/platform-browser';
import {{ NgModule }} from '@angular/core';
import {{ RouterModule,Routes }} from '@angular/router';
import {{ HttpModule }} from '@angular/http';
import {{ FormsModule,ReactiveFormsModule }} from '@angular/forms';

import {{ AppComponent }} from './components/app/app.component';
import {{ NavmenuComponent }} from './components/navmenu/navmenu.component';
import {{ HomeComponent }} from './components/home/home.component';
import {{ BlogComponent }} from './components/Blog/Blog.component';
import {{ AboutComponent }} from './components/about/about.component';


@NgModule({{
    bootstrap: [AppComponent],
    declarations: [AppComponent, NavmenuComponent, HomeComponent, BlogComponent, AboutComponent],
    providers: [],
    imports: [
        HttpModule, BrowserModule, FormsModule, ReactiveFormsModule,
        RouterModule.forRoot([
            {{ path: 'home', component: HomeComponent }},
            {{ path: 'blog', component: BlogComponent }},
            {{ path: 'about', component: AboutComponent }},
            {{ path: '', redirectTo: 'home', pathMatch: 'full' }},
            {{ path: '**', component: HomeComponent }}
        ])
    ],
}})
export class AppModule {{ }}";
        }

        //assets
        public static string indexHTML() {

            return
@"<!DOCTYPE html>
<html>
    <head>
        <meta charset=""utf-8"" />
        <meta http-equiv = ""X-UA-Compatible"" content = ""IE=edge"" />
        <meta name = ""viewport"" content =""width=device-width, initial-scale=1.0"" />
        <base href = ""/"" />
        <link href = ""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"" rel = ""stylesheet"" />
        <script src = ""https://code.jquery.com/jquery-3.2.1.min.js"" crossorigin = ""anonymous"" ></script>
        <script src = ""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"" ></script>
    </head>
    <body>
        <app> Loading...</app>
        <script type = ""text/javascript"" src = ""ClientApp/dist/ng-application.js"" ></script>
    </body>
</html>";

        }

        //main
        public static string maints()
        {
            return
$@"
import {{ enableProdMode }} from '@angular/core';
import {{ platformBrowserDynamic }} from '@angular/platform-browser-dynamic';

import {{ AppModule }} from './app/app.module';
import {{ environment }} from './config/environment';

if (environment.production) {{
  enableProdMode();
}}

platformBrowserDynamic().bootstrapModule(AppModule)
  .catch(err => console.log(err));
";
        }

        //tsconfig
        public static string tsConfig()
        {
            return
$@"{{
  ""compileOnSave"": false,
  ""compilerOptions"": {{ 
    ""outDir"": ""../out-tsc/app"",
    ""baseUrl"": ""./"",
    ""module"": ""es2015"",
    ""types"": [],
    ""sourceMap"": true,
    ""declaration"": false,
    ""moduleResolution"": ""node"",
    ""emitDecoratorMetadata"": true,
    ""experimentalDecorators"": true,
    ""target"": ""es5"",
    ""typeRoots"": [""node_modules/@types""],
    ""lib"": [""es2017"", ""dom""  ]
    }}
}}
";
        }



        // Fichiers de Configuration
        public static string packageJson()
        {
            return
$@"
{{
  ""name"": ""modeleangularwebpack"",
  ""version"": ""0.0.0"",
  ""license"": ""MIT"",
  ""scripts"": {{
    ""start"": ""webpack-dev-server --port=4200"",
    ""build"": ""webpack"",
    ""watch"": ""webpack --watch""
  }},
  ""private"": true,
  ""dependencies"": {{
    ""@angular/animations"": ""^5.0.0"",
    ""@angular/common"": ""^5.0.0"",
    ""@angular/compiler"": ""^5.0.0"",
    ""@angular/core"": ""^5.0.0"",
    ""@angular/forms"": ""^5.0.0"",
    ""@angular/http"": ""^5.0.0"",
    ""@angular/platform-browser"": ""^5.0.0"",
    ""@angular/platform-browser-dynamic"": ""^5.0.0"",
    ""@angular/router"": ""^5.0.0"",
    ""core-js"": ""^2.4.1"",
    ""rxjs"": ""^5.5.2"",
    ""zone.js"": ""^0.8.14""
  }},
  ""devDependencies"": {{
    ""@angular/cli"": ""1.5.4"",
    ""@angular/compiler-cli"": ""^5.0.0"",
    ""@angular/language-service"": ""^5.0.0"",
    ""@types/node"": ""~6.0.60"",
    ""ts-node"": ""~3.2.0"",
    ""typescript"": ""~2.4.2"",
    ""webpack-dev-server"": ""~2.9.3"",
    ""webpack"": ""~3.8.1"",
    ""autoprefixer"": ""^6.5.3"",
    ""css-loader"": ""^0.28.1"",
    ""cssnano"": ""^3.10.0"",
    ""exports-loader"": ""^0.6.3"",
    ""file-loader"": ""^1.1.5"",
    ""html-webpack-plugin"": ""^2.29.0"",
    ""less-loader"": ""^4.0.5"",
    ""postcss-loader"": ""^2.0.8"",
    ""postcss-url"": ""^7.1.2"",
    ""raw-loader"": ""^0.5.1"",
    ""sass-loader"": ""^6.0.3"",
    ""source-map-loader"": ""^0.2.0"",
    ""istanbul-instrumenter-loader"": ""^2.0.0"",
    ""style-loader"": ""^0.13.1"",
    ""stylus-loader"": ""^3.0.1"",
    ""url-loader"": ""^0.6.2"",
    ""circular-dependency-plugin"": ""^3.0.0"",
    ""webpack-concat-plugin"": ""1.4.0"",
    ""copy-webpack-plugin"": ""^4.1.1"",
    ""uglifyjs-webpack-plugin"": ""1.0.0""
   }}
}}";
        }
        public static string webpack() {
            return
$@"
const fs = require('fs');
const path = require('path');
const CopyWebpackPlugin = require('copy-webpack-plugin');
const ProgressPlugin = require('webpack/lib/ProgressPlugin');
const CircularDependencyPlugin = require('circular-dependency-plugin');
const HtmlWebpackPlugin = require('html-webpack-plugin');
const rxPaths = require('rxjs/_esm5/path-mapping');
const autoprefixer = require('autoprefixer');
const postcssUrl = require('postcss-url');
const cssnano = require('cssnano');
const customProperties = require('postcss-custom-properties');

const {{ NoEmitOnErrorsPlugin,SourceMapDevToolPlugin, NamedModulesPlugin }} = require('webpack');
const {{ NamedLazyChunksWebpackPlugin,BaseHrefWebpackPlugin }} = require('@angular/cli/plugins/webpack');
const {{ CommonsChunkPlugin }} = require('webpack').optimize;
const {{ AngularCompilerPlugin }} = require('@ngtools/webpack');

const nodeModules = path.join(process.cwd(), 'node_modules');
const realNodeModules = fs.realpathSync(nodeModules);
const genDirNodeModules = path.join(process.cwd(), 'ClientApp', '$$_gendir', 'node_modules');
const entryPoints = [""inline"",""polyfills"",""sw - register"",""styles"",""vendor"",""main""];
const minimizeCss = false;
            const baseHref = """";
            const deployUrl = """";
            const postcssPlugins = function() {{
                // safe settings based on: https://github.com/ben-eb/cssnano/issues/358#issuecomment-283696193
                const importantCommentRe = /@preserve | @license |[@#]\s*source(?:Mapping)?URL|^!/i;
        const minimizeOptions = {{
            autoprefixer: false,
            safe: true,
            mergeLonghand: false,
            discardComments: {{ remove: (comment) => !importantCommentRe.test(comment) }}
            }};
            return [
                postcssUrl({{
                url: (URL) => {{
                    const {{ url }} = URL;
                    // Only convert root relative URLs, which CSS-Loader won't process into require().
                    if (!url.startsWith('/') || url.startsWith('//'))
                    {{
                        return URL.url;
                    }}
                    if (deployUrl.match(/:\/\//)) {{
                        // If deployUrl contains a scheme, ignore baseHref use deployUrl as is.
                        return `${{ deployUrl.replace(/\/$/, '')}}${{ url}}`;
                }}
                        else if (baseHref.match(/:\/\//)) {{
                        // If baseHref contains a scheme, include it as is.
                        return baseHref.replace(/\/$/, '') +
                                `/${{ deployUrl}}/${{ url}}`.replace(/\/\/ +/g, '/');
            }}
                    else {{
                // Join together base-href, deploy-url and the original URL.
                // Also dedupe multiple slashes into single ones.
                return `/${{ baseHref}}/${{ deployUrl}}/${{ url}}`.replace(/\/\/ +/g, '/');
            }}
        }}
    }}),
            autoprefixer(),
            customProperties({{ preserve: true }})
        ].concat(minimizeCss?[cssnano(minimizeOptions)] : []);
}};




module.exports = {{
  ""resolve"": {{
    ""extensions"": ["".ts"","".js""],
    ""modules"": [""./node_modules"",""./node_modules""],
    ""symlinks"": true,
    ""alias"": rxPaths(),
    ""mainFields"": [""browser"",""module"",""main"" ]
  }},
  ""resolveLoader"": {{
    ""modules"": [""./node_modules"",""./node_modules""],
    ""alias"": rxPaths()
  }},
  ""entry"": {{
    ""main"": [ ""./ClientApp\\main.ts"" ],
    ""polyfills"": [""./ClientApp\\config\\polyfills.ts"" ],
    ""styles"": [""./ClientApp\\config\\styles.css""  ]
  }},
  ""output"": {{
    ""path"": path.join(process.cwd(), ""ClientApp/dist""),
    ""filename"": ""[name].bundle.js"",
    ""chunkFilename"": ""[id].chunk.js"",
    ""crossOriginLoading"": false
  }},
  ""module"": {{
    ""rules"": [
      {{ ""test"": /\.html$/, ""loader"": ""raw-loader"" }},
      {{ ""test"": /\.(eot|svg|cur)$/,  ""loader"": ""file-loader"", ""options"": {{ ""name"": ""[name].[hash:20].[ext]"",""limit"": 10000}}}},
      {{ ""test"": /\.(jpg|png|webp|gif|otf|ttf|woff|woff2|ani)$/, ""loader"": ""url-loader"", ""options"": {{ ""name"": ""[name].[hash:20].[ext]"", ""limit"": 10000 }}}},
      {{ ""exclude"": [path.join(process.cwd(), ""ClientApp\\config\\styles.css"")],
        ""test"": /\.css$/, ""use"": [
          ""exports-loader?module.exports.toString()"",
          {{ ""loader"": ""css-loader"",""options"": {{ ""sourceMap"": false, ""importLoaders"": 1 }} }},
          {{ ""loader"": ""postcss-loader"",""options"": {{ ""ident"": ""postcss"",  ""plugins"": postcssPlugins, ""sourceMap"": false}} }}
        ]
      }},
      {{
        ""exclude"": [
          path.join(process.cwd(), ""ClientApp\\config\\styles.css"")
        ],
        ""test"": /\.scss$|\.sass$/,
        ""use"": [
          ""exports-loader?module.exports.toString()"",
          {{
            ""loader"": ""css-loader"",
            ""options"": {{
              ""sourceMap"": false,
              ""importLoaders"": 1
            }}
          }},
          {{
            ""loader"": ""postcss-loader"",
            ""options"": {{
              ""ident"": ""postcss"",
              ""plugins"": postcssPlugins,
              ""sourceMap"": false
            }}
          }},
          {{
            ""loader"": ""sass-loader"",
            ""options"": {{
              ""sourceMap"": false,
              ""precision"": 8,
              ""includePaths"": []
            }}
          }}
        ]
      }},
      {{
        ""exclude"": [
          path.join(process.cwd(), ""ClientApp\\config\\styles.css"")
        ],
        ""test"": /\.less$/,
        ""use"": [
          ""exports-loader?module.exports.toString()"",
          {{
            ""loader"": ""css-loader"",
            ""options"": {{
              ""sourceMap"": false,
              ""importLoaders"": 1
            }}
          }},
          {{
            ""loader"": ""postcss-loader"",
            ""options"": {{
              ""ident"": ""postcss"",
              ""plugins"": postcssPlugins,
              ""sourceMap"": false
            }}
          }},
          {{
            ""loader"": ""less-loader"",
            ""options"": {{
              ""sourceMap"": false
            }}
          }}
        ]
      }},
      {{
        ""exclude"": [
          path.join(process.cwd(), ""ClientApp\\config\\styles.css"")
        ],
        ""test"": /\.styl$/,
        ""use"": [
          ""exports-loader?module.exports.toString()"",
          {{
            ""loader"": ""css-loader"",
            ""options"": {{
              ""sourceMap"": false,
              ""importLoaders"": 1
            }}
          }},
          {{
            ""loader"": ""postcss-loader"",
            ""options"": {{
              ""ident"": ""postcss"",
              ""plugins"": postcssPlugins,
              ""sourceMap"": false
            }}
          }},
          {{
            ""loader"": ""stylus-loader"",
            ""options"": {{
              ""sourceMap"": false,
              ""paths"": []
            }}
          }}
        ]
      }},
      {{
        ""include"": [
          path.join(process.cwd(), ""ClientApp\\config\\styles.css"")
        ],
        ""test"": /\.css$/,
        ""use"": [
          ""style-loader"",
          {{
            ""loader"": ""css-loader"",
            ""options"": {{
              ""sourceMap"": false,
              ""importLoaders"": 1
            }}
          }},
          {{
            ""loader"": ""postcss-loader"",
            ""options"": {{
              ""ident"": ""postcss"",
              ""plugins"": postcssPlugins,
              ""sourceMap"": false
            }}
          }}
        ]
      }},
      {{
        ""include"": [
          path.join(process.cwd(), ""ClientApp\\config\\styles.css"")
        ],
        ""test"": /\.scss$|\.sass$/,
        ""use"": [
          ""style-loader"",
          {{
            ""loader"": ""css-loader"",
            ""options"": {{
              ""sourceMap"": false,
              ""importLoaders"": 1
            }}
          }},
          {{
            ""loader"": ""postcss-loader"",
            ""options"": {{
              ""ident"": ""postcss"",
              ""plugins"": postcssPlugins,
              ""sourceMap"": false
            }}
          }},
          {{
            ""loader"": ""sass-loader"",
            ""options"": {{
              ""sourceMap"": false,
              ""precision"": 8,
              ""includePaths"": []
            }}
          }}
        ]
      }},
      {{
        ""include"": [
          path.join(process.cwd(), ""ClientApp\\config\\styles.css"")
        ],
        ""test"": /\.less$/,
        ""use"": [
          ""style-loader"",
          {{
            ""loader"": ""css-loader"",
            ""options"": {{
              ""sourceMap"": false,
              ""importLoaders"": 1
            }}
          }},
          {{
            ""loader"": ""postcss-loader"",
            ""options"": {{
              ""ident"": ""postcss"",
              ""plugins"": postcssPlugins,
              ""sourceMap"": false
            }}
          }},
          {{
            ""loader"": ""less-loader"",
            ""options"": {{
              ""sourceMap"": false
            }}
          }}
        ]
      }},
      {{
        ""include"": [
          path.join(process.cwd(), ""ClientApp\\config\\styles.css"")
        ],
        ""test"": /\.styl$/,
        ""use"": [
          ""style-loader"",
          {{
            ""loader"": ""css-loader"",
            ""options"": {{
              ""sourceMap"": false,
              ""importLoaders"": 1
            }}
          }},
          {{
            ""loader"": ""postcss-loader"",
            ""options"": {{
              ""ident"": ""postcss"",
              ""plugins"": postcssPlugins,
              ""sourceMap"": false
            }}
          }},
          {{
            ""loader"": ""stylus-loader"",
            ""options"": {{
              ""sourceMap"": false,
              ""paths"": []
            }}
          }}
        ]
      }},
      {{
        ""test"": /\.ts$/,
        ""loader"": ""@ngtools/webpack""
      }}
    ]
  }},
  ""plugins"": [
    new NoEmitOnErrorsPlugin(),
    new CopyWebpackPlugin([
      {{
    ""context"": ""ClientApp"",
        ""to"": """",
        ""from"": {{
        ""glob"": ""assets/**/*"",
          ""dot"": true
        }}
}},
      {{
        ""context"": ""ClientApp"",
        ""to"": """",
        ""from"": {{
          ""glob"": ""favicon.ico"",
          ""dot"": true
        }}
      }}
    ], {{
      ""ignore"": [
        "".gitkeep"",
        ""**/.DS_Store"",
        ""**/Thumbs.db""
      ],
      ""debug"": ""warning""
    }}),
    new ProgressPlugin(),
    new CircularDependencyPlugin({{
    ""exclude"": /(\\|\/)node_modules(\\|\/) /,
      ""failOnError"": false
    }}),
    new NamedLazyChunksWebpackPlugin(),
    new HtmlWebpackPlugin({{
    ""template"": ""./ClientApp\\config\\index.html"",
      ""filename"": ""./index.html"",
      ""hash"": false,
      ""inject"": true,
      ""compile"": true,
      ""favicon"": false,
      ""minify"": false,
      ""cache"": true,
      ""showErrors"": true,
      ""chunks"": ""all"",
      ""excludeChunks"": [],
      ""title"": ""Webpack App"",
      ""xhtml"": true,
      ""chunksSortMode"": function sort(left, right)
{{
    let leftIndex = entryPoints.indexOf(left.names[0]);
    let rightindex = entryPoints.indexOf(right.names[0]);
    if (leftIndex > rightindex)
    {{
        return 1;
    }}
    else if (leftIndex < rightindex)
    {{
        return -1;
    }}
    else
    {{
        return 0;
    }}
}}
    }}),
    new BaseHrefWebpackPlugin({{ }}),
    new CommonsChunkPlugin({{
    ""name"": [
        ""inline""
      ],
      ""minChunks"": null
    }}),
    new CommonsChunkPlugin({{
    ""name"": [
        ""vendor""
      ],
      ""minChunks"": (module) => {{
                return module.resource
                    && (module.resource.startsWith(nodeModules)
                        || module.resource.startsWith(genDirNodeModules)
                        || module.resource.startsWith(realNodeModules));
            }},
      ""chunks"": [
        ""main""
      ]
    }}),
    new SourceMapDevToolPlugin({{
    ""filename"": ""[file].map[query]"",
      ""moduleFilenameTemplate"": ""[resource-path]"",
      ""fallbackModuleFilenameTemplate"": ""[resource-path]?[hash]"",
      ""sourceRoot"": ""webpack:///""
    }}),
    new CommonsChunkPlugin({{
    ""name"": [
        ""main""
      ],
      ""minChunks"": 2,
      ""async"": ""common""
    }}),
    new NamedModulesPlugin({{ }}),
    new AngularCompilerPlugin({{
    ""mainPath"": ""main.ts"",
      ""platform"": 0,
      ""hostReplacementPaths"": {{
        ""environments\\config\\environment.ts"": ""environments\\config\\environment.ts""
      }},
      ""sourceMap"": true,
      ""tsConfigPath"": ""ClientApp\\tsconfig.json"",
      ""skipCodeGeneration"": true,
      ""compilerOptions"": {{ }}
}})
  ],
  ""node"": {{
    ""fs"": ""empty"",
    ""global"": true,
    ""crypto"": ""empty"",
    ""tls"": ""empty"",
    ""net"": ""empty"",
    ""process"": true,
    ""module"": false,
    ""clearImmediate"": false,
    ""setImmediate"": false
  }},
  ""devServer"": {{
    ""historyApiFallback"": true
  }}
}};

";

        }
        
        
        // autre
        public static string Important()
        {
            return
@" Configuration de visual studio :
a- installer NPM task runner.
b- allez dans Outils -> Options -> Projets et solutions -> Outils Web externes, et déplacez l'entrée $ (PATH) à la deuxième position dans la liste.

1- Ajouter a .csproj
  <TypeScriptCompileBlocked>true</TypeScriptCompileBlocked>
  <TypeScriptToolsVersion>2.3</TypeScriptToolsVersion>


2- Modifier _Layout.cshtml
    <head>
        <meta charset=""utf-8"" />
        <meta http-equiv = ""X-UA-Compatible"" content = ""IE=edge"" />
        <meta name = ""viewport"" content = ""width=device-width, initial-scale=1.0"" >
        <base href = ""/"" /> 
        <link href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"" rel=""stylesheet"">
        <script src = ""https://code.jquery.com/jquery-3.2.1.min.js""  crossorigin = ""anonymous""></script>
        <script src = ""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""  crossorigin = ""anonymous"" ></script>
    </head>


3-Modifer Index.cshtml

    <app>Loading...</app>
    <script type = ""text/javascript"" src=""~/ClientApp/dist/ng-application.js""></script>
";
        }





        // fichier pour un projet avec angular cli
        public static string ng_appmodule()
        {
            return
$@"import {{ BrowserModule }} from '@angular/platform-browser';
import {{ NgModule }} from '@angular/core';
import {{ FormsModule }} from '@angular/forms';
import {{ HttpModule }} from '@angular/http';

import {{ AppComponent }} from './components/app/app.component';

@NgModule({{
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [],
  bootstrap: [AppComponent]
}})
export class AppModule {{ }}
";
        }
        public static string ng_envprod()
        {
            return
@"export const environment = {
  production: true
};";
        }
        public static string ng_env()
        {
            return
@"export const environment = {
  production: false
};";
        }
        public static string ng_index()
        {
            return
$@"<!doctype html>
<html>
<head>
  <meta charset=""utf-8"">
    <title> InitCreche </title>
    <base href = ""/"">
    <meta name = ""viewport"" content = ""width=device-width, initial-scale=1"" >
</head>
<body>
    <my-app></my-app>
</body>
</html>";
        }
        public static string ng_maints()
        {
            return
$@"import {{ enableProdMode }} from '@angular/core';
import {{ platformBrowserDynamic }} from '@angular/platform-browser-dynamic';

import {{ AppModule }} from './app/app.module';
import {{ environment }} from './environments/environment';

if (environment.production) {{
  enableProdMode();
}}

platformBrowserDynamic().bootstrapModule(AppModule);
";
        }
        public static string ng_polyfills()
        {
            return
$@"/**
 * This file includes polyfills needed by Angular and is loaded before the app.
 * You can add your own extra polyfills to this file.
 *
 * This file is divided into 2 sections:
 *   1. Browser polyfills. These are applied before loading ZoneJS and are sorted by browsers.
 *   2. Application imports. Files imported after ZoneJS that should be loaded before your main
 *      file.
 *
 * The current setup is for so-called ""evergreen"" browsers; the last versions of browsers that
 * automatically update themselves. This includes Safari >= 10, Chrome >= 55(including Opera),
 *Edge >= 13 on the desktop, and iOS 10 and Chrome on mobile.
 *
 *Learn more in https://angular.io/docs/ts/latest/guide/browser-support.html
 */
 /***************************************************************************************************
 * BROWSER POLYFILLS
 */
 /** IE9, IE10 and IE11 requires all of the following polyfills. **/
 import 'core-js/shim'
 import 'core-js/es6/symbol';
 import 'core-js/es6/object';
 import 'core-js/es6/function';
 import 'core-js/es6/parse-int';
 import 'core-js/es6/parse-float';
 import 'core-js/es6/number';
 import 'core-js/es6/math';
 import 'core-js/es6/string';
 import 'core-js/es6/date';
 import 'core-js/es6/';
 import 'core-js/es6/array';
 import 'core-js/es6/regexp';
 import 'core-js/es6/map';
 import 'core-js/es6/set';
 import 'core-js/es7/array';
 import 'core-js/es6/promise'

/** IE10 and IE11 requires the following for NgClass support on SVG elements */
// import 'classlist.js';  // Run `npm install --save classlist.js`.

/** IE10 and IE11 requires the following to support `@angular/animation`. */
// import 'web-animations-js';  // Run `npm install --save web-animations-js`.

/** Evergreen browsers require these. **/
import 'core-js/es6/reflect';
import 'core-js/es7/reflect';
import 'rsvp';
/** ALL Firefox browsers require the following to support `@angular/animation`. **/
// import 'web-animations-js';  // Run `npm install --save web-animations-js`.

/***************************************************************************************************
* Zone JS is required by Angular itself.
*/
import 'zone.js/dist/zone';  // Included with Angular CLI.

/***************************************************************************************************
* APPLICATION IMPORTS
*/
/**
* Date, currency, decimal and percent pipes.
* Needed for: All but Chrome, Firefox, Edge, IE11 and Safari 10
*/
// import 'intl';  // Run `npm install --save intl`.
/**
* Need to import at least one locale-data with intl.
*/
// import 'intl/locale-data/jsonp/en';";
        }
        public static string ng_tsconfigapp()
        {
            return
$@"{{
  ""extends"": ""../ tsconfig.json"",
  ""compilerOptions"": {{
        ""outDir"": ""../out-tsc/app"",
        ""module"": ""es2015"",
        ""baseUrl"": """",
        ""types"": []
    }},
  ""exclude"": [ ""**/*.spec.ts"" ]
}}";
        }
        public static string ng_typing()
        {
            return
$@"declare var module: NodeModule;
interface NodeModule {{
  id: string;
}}";
        }
        public static string ng_angularCli()
        {
            return
$@"{{
    ""$schema"": ""./node_modules/@angular/cli/lib/config/schema.json"",
    ""project"": {{
        ""name"": "" ""
    }},
    ""apps"": [
         {{
            ""assets"": [ ""assets"" ],
            ""environments"": {{
                ""dev"": ""environments/environment.ts"",
                ""prod"": ""environments/environment.prod.ts""
            }},
            ""environmentSource"": ""environments/environment.ts"",
            ""index"": ""index.html"",
            ""main"": ""main.ts"",
            ""outDir"": ""dist"",
            ""polyfills"": ""polyfills.ts"",
            ""prefix"": ""app"",
            ""root"": ""ClientApp"",
            ""scripts"": [],
            ""tsconfig"": ""tsconfig.app.json""
        }}
    ],
    ""lint"": [
        {{
            ""project"": ""/tsconfig.app.json""
        }}   
    ],
    ""defaults"": {{
        ""styleExt"": ""css"",
        ""component"": {{}}
    }}
}}";
        }
        public static string ng_packageJson()
        {

            return
$@"{{
    ""name"": "" "",
    ""version"": ""0.0.1"",
    ""license"": ""MIT"",
    ""scripts"": {{
        ""ng"": ""ng"",
        ""start"": ""ng serve"",
        ""build"": ""ng build"",
        ""test"": ""ng test"",
        ""lint"": ""ng lint"",
        ""e2e"": ""ng e2e"",
        ""watch"": ""ng build -op ClientApp/dist -w""
    }},
    ""private"": true,
    ""dependencies"": {{
        ""@angular/common"": ""^4.0.0"",
        ""@angular/compiler"": ""^4.0.0"",
        ""@angular/core"": ""^4.0.0"",
        ""@angular/forms"": ""^4.0.0"",
        ""@angular/http"": ""^4.0.0"",
        ""@angular/platform-browser"": ""^4.0.0"",
        ""@angular/platform-browser-dynamic"": ""^4.0.0"",
        ""@angular/router"": ""^4.0.0"",
        ""bootstrap"": ""^3.3.7"",
        ""core-js"": ""^2.4.1"",
        ""es6-promise"": ""^4.1.0"",
        ""rsvp"": ""^3.5.0"",
        ""rxjs"": ""^5.1.0"",
        ""webpack"": ""^2.2.0"",
        ""zone.js"": ""^0.8.4""
    }},
    ""devDependencies"": {{
        ""@angular/cli"": ""1.0.3"",
        ""@angular/compiler-cli"": ""^4.0.0"",
        ""@types/jasmine"": ""2.5.38"",
        ""@types/node"": ""~6.0.60"",
        ""codelyzer"": ""~2.0.0"",
        ""jasmine-core"": ""~2.5.2"",
        ""jasmine-spec-reporter"": ""~3.2.0"",
        ""karma"": ""~1.4.1"",
        ""karma-chrome-launcher"": ""~2.1.1"",
        ""karma-cli"": ""~1.0.1"",
        ""karma-jasmine"": ""~1.1.0"",
        ""karma-jasmine-html-reporter"": ""^0.2.2"",
        ""karma-coverage-istanbul-reporter"": ""^0.2.0"",
        ""protractor"": ""~5.1.0"",
        ""ts-node"": ""~2.0.0"",
        ""tslint"": ""~4.5.0"",
        ""typescript"": ""~2.2.0""
    }},
    ""-vs-binding"": {{
        ""ProjectOpened"": [ ""watch"" ]
    }}
}}";
        }
        public static string ng_tsConfig()
        {
            return
$@"{{
    ""compileOnSave"": false,
    ""compilerOptions"": {{
        ""outDir"": ""./dist/out-tsc"",
        ""baseUrl"": ""ClientApp"",
        ""sourceMap"": true,
        ""declaration"": false,
        ""moduleResolution"": ""node"",
        ""emitDecoratorMetadata"": true,
        ""experimentalDecorators"": true,
        ""target"": ""es5"",
        ""typeRoots"": [""node_modules/@types""],
        ""lib"": [ ""es2016"", ""dom"" ]
    }}
}}";
        }
        public static string ng_tslint()
        {

            return
$@"{{
    ""rules"": {{
        ""callable-types"": true,
        ""class-name"": true,
        ""comment-format"": [
            true,
            ""check-space""
        ],
        ""curly"": true,
        ""eofline"": true,
        ""forin"": true,
        ""import-blacklist"": [
            true,
            ""rxjs""
        ],
        ""import-spacing"": true,
        ""indent"": [
            true,
            ""spaces""
        ],
        ""interface-over-type-literal"": true,
        ""label-position"": true,
        ""max-line-length"": [
            true,
            140
        ],
        ""member-access"": false,
        ""member-ordering"": [
            true,
            ""static-before-instance"",
            ""variables-before-functions""
        ],
        ""no-arg"": true,
        ""no-bitwise"": true,
        ""no-console"": [
            true,
            ""debug"",
            ""info"",
            ""time"",
            ""timeEnd"",
            ""trace""
        ],
        ""no-construct"": true,
        ""no-debugger"": true,
        ""no-empty"": false,
        ""no-empty-interface"": true,
        ""no-eval"": true,
        ""no-inferrable-types"": [
            true,
            ""ignore-params""
        ],
        ""no-shadowed-variable"": true,
        ""no-string-literal"": false,
        ""no-string-throw"": true,
        ""no-switch-case-fall-through"": true,
        ""no-trailing-whitespace"": true,
        ""no-unused-expression"": true,
        ""no-use-before-declare"": true,
        ""no-var-keyword"": true,
        ""object-literal-sort-keys"": false,
        ""one-line"": [
            true,
            ""check-open-brace"",
            ""check-catch"",
            ""check-else"",
            ""check-whitespace""
        ],
        ""prefer-const"": true,
        ""quotemark"": [
            true,
            ""single""
        ],
        ""radix"": true,
        ""semicolon"": [
            ""always""
        ],
        ""triple-equals"": [
            true,
            ""allow-null-check""
        ],
        ""typedef-whitespace"": [
            true,
            {{
                ""call-signature"": ""nospace"",
                ""index-signature"": ""nospace"",
                ""parameter"": ""nospace"",
                ""property-declaration"": ""nospace"",
                ""variable-declaration"": ""nospace""
            }}
        ],
        ""typeof-compare"": true,
        ""unified-signatures"": true,
        ""variable-name"": false,
        ""whitespace"": [
            true,
            ""check-branch"",
            ""check-decl"",
            ""check-operator"",
            ""check-separator"",
            ""check-type""
        ],
        ""directive-selector"": [
            true,
            ""attribute"",
            ""app"",
            ""camelCase""
        ],
        ""component-selector"": [
            true,
            ""element"",
            ""app"",
            ""kebab-case""
        ],
        ""use-input-property-decorator"": true,
        ""use-output-property-decorator"": true,
        ""use-host-property-decorator"": true,
        ""no-input-rename"": true,
        ""no-output-rename"": true,
        ""use-life-cycle-interface"": true,
        ""use-pipe-transform-interface"": true,
        ""component-class-suffix"": true,
        ""directive-class-suffix"": true,
        ""no-access-missing-member"": true,
        ""templates-use-public"": true,
        ""invoke-injectable"": true
    }},
    ""rulesDirectory"": [
        ""node_modules/codelyzer""
    ]
}}";
        }

    }
}

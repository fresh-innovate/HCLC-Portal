///<reference path="../../typings/index.d.ts"/>
import { bootstrap } from "@angular/platform-browser-dynamic";
import { bind, enableProdMode, provide } from '@angular/core';

import { AppComponent } from "./app.component";

//enableProdMode(); //Uncomment for production

bootstrap(AppComponent, []);
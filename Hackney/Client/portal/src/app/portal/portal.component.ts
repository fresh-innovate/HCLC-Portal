import { Component, OnInit} from "@angular/core";
import { ROUTER_DIRECTIVES } from '@angular/router';

import {Item} from "./models/item";
import {ItemService} from "./services/item-service";
import {ItemComponent} from "./components/item.component";

@Component({
    templateUrl: '/portal/app/portal/portal.component.html',
	styleUrls: ['/portal/app/portal/portal.component.css'],
	directives: [ ROUTER_DIRECTIVES ],
    providers: [ItemService]
})
export class PortalComponent implements OnInit {
    portalTitle : string;
    portalType : string = "client";
    constructor() {
         this.portalType = "client";
    }
    ngOnInit() {
        this.portalTitle = "Welcome to our portal";
    }
}
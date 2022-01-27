"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const body_1 = require("../Products/body");
const footer_1 = require("../Products/footer");
const header_1 = require("../Products/header");
const menu_1 = require("../Products/menu");
const AbstractPage_1 = require("./AbstractPage");
class NewsPage extends AbstractPage_1.AbstractPage {
    assemblyPage() {
        this.parts.push(new header_1.Header);
        this.parts.push(new body_1.Body);
        this.parts.push(new menu_1.Menu());
        this.parts.push(new footer_1.Footer());
    }
}

"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.BlogPage = void 0;
const body_1 = require("../Products/body");
const footer_1 = require("../Products/footer");
const header_1 = require("../Products/header");
const AbstractPage_1 = require("./AbstractPage");
class BlogPage extends AbstractPage_1.AbstractPage {
    assemblyPage() {
        this.parts.push(new header_1.Header);
        this.parts.push(new body_1.Body);
        this.parts.push(new footer_1.Footer());
    }
}
exports.BlogPage = BlogPage;

"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const body_1 = require("../Products/body");
const header_1 = require("../Products/header");
const AbstractPage_1 = require("./AbstractPage");
class ResumePage extends AbstractPage_1.AbstractPage {
    assemblyPage() {
        this.parts.push(new header_1.Header);
        this.parts.push(new body_1.Body);
    }
}

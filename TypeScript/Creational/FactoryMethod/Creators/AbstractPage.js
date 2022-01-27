"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.AbstractPage = void 0;
class AbstractPage {
    constructor() {
        this._pageParts = [];
        this.assemblyPage();
    }
    get parts() {
        return this._pageParts;
    }
}
exports.AbstractPage = AbstractPage;

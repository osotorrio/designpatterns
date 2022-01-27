"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Menu = void 0;
class Menu {
    constructor() {
        this.width = 20;
        this.heigh = 500;
        this.content = "This is a MENU";
    }
    render() {
        console.log(`${this.content}\n${this.width}\npixels\nwidth\n${this.heigh}\npixels\nheight`);
    }
}
exports.Menu = Menu;

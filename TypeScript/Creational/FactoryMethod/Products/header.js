"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Header = void 0;
class Header {
    constructor() {
        this.x = 0;
        this.y = 0;
        this.width = 100;
        this.heigh = 20;
        this.content = "This is a HEADER";
    }
    render() {
        console.log(`${this.content} ${this.width}x${this.heigh} pixels`);
    }
}
exports.Header = Header;

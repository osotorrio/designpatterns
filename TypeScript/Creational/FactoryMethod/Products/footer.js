"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Footer = void 0;
class Footer {
    constructor() {
        this.width = 100;
        this.heigh = 10;
        this.content = "This is a FOOTER";
    }
    render() {
        console.log(`${this.content} ${this.width}x${this.heigh} pixels`);
    }
}
exports.Footer = Footer;

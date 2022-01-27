"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Body = void 0;
class Body {
    constructor() {
        this.width = 100;
        this.heigh = 500;
        this.content = "This is a BODY";
    }
    render() {
        console.log(`${this.content}\n${this.width}pixels width\n${this.heigh}pixels height`);
    }
}
exports.Body = Body;

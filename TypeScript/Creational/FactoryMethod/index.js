"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const BlogPage_1 = require("./Creators/BlogPage");
function clientCode(page) {
    // ...
    console.log('Client: I\'m not aware of the creator\'s class, but it still works.');
    page.parts.forEach(part => {
        part.render();
    });
    // ...
}
/**
 * The Application picks a creator's type depending on the configuration or
 * environment.
 */
clientCode(new BlogPage_1.BlogPage());

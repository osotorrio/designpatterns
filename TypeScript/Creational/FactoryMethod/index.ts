import { AbstractPage } from "./Creators/AbstractPage";
import { BlogPage } from "./Creators/BlogPage";

function clientCode(page: AbstractPage) {
    // ...
    console.log('Client: I\'m not aware of the creator\'s class, but it still works.');

    page.parts.forEach(part => {
        part.render();
    });
    // ...
}

clientCode(new BlogPage());

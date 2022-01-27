import { Body } from "../Products/body";
import { Footer } from "../Products/footer";
import { Header } from "../Products/header";
import { AbstractPage } from "./AbstractPage";

export class BlogPage extends AbstractPage {
    public assemblyPage(): void {
        this.parts.push(new Header);
        this.parts.push(new Body);
        this.parts.push(new Footer());
    }
}
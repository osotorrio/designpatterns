import { Body } from "../Products/body";
import { Footer } from "../Products/footer";
import { Header } from "../Products/header";
import { Menu } from "../Products/menu";
import { AbstractPage } from "./AbstractPage";

class NewsPage extends AbstractPage {
    public assemblyPage(): void {
        this.parts.push(new Header);
        this.parts.push(new Body);
        this.parts.push(new Menu());
        this.parts.push(new Footer());
    }
}
import { Body } from "../Products/body";
import { Header } from "../Products/header";
import { AbstractPage } from "./AbstractPage";

class ResumePage extends AbstractPage {
    public assemblyPage(): void {
        this.parts.push(new Header);
        this.parts.push(new Body);
    }
}
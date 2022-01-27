import { IPagePart } from "./IPartPage";

export class Menu implements IPagePart {
    width: number = 20;
    heigh: number = 500;
    content: string = "This is a MENU"

    public render(): void {
        console.log(`${this.content}\n${this.width}\npixels\nwidth\n${this.heigh}\npixels\nheight`);
    }
}
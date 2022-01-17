function Click(){
    this.handlers = [];
}

Click.prototype = {
    attach: function (handler) {
        this.handlers.push(handler);
    },
    detach: function (handler){
        this.handlers = this.handlers.filter(
            function (item) {
                if (item !== handler) return item;
            }
        );
    },
    fire: function () {
        this.handlers.forEach(handler => {
            handler.handle();
        })
    }
};

//---------------------------------------------

const baseHandler = {
    handle: function () {
        console.log(this.message);
    }
};

function ErrorHandler(){
    this.message = "ERROR!!";
}
ErrorHandler.prototype = baseHandler;

function WarningHandler(){
    this.message = "WARNING!!";
}
WarningHandler.prototype = baseHandler;

//---------------------------------------------

const errorHandler = new ErrorHandler();
const warningHandler = new WarningHandler();

const click = new Click();
click.attach(errorHandler);
click.attach(warningHandler);
click.fire();
click.detach(warningHandler);
click.fire();


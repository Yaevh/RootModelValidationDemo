# RootModelValidationDemo
As of 2.1.0, validation attributes are allowed on controller parameters, bound controller parameters, page model properties and handler method parameters. They are however not allowed on page models themselves, which makes it impossible to implement complex, multi-property validation in Razor Pages declaratively. Right now one must either invoke such validation manually, or encapsulate all properties in a custom viewmodel and decorate that viewmodel with a validation attribute, which is rather awkward considering that `PageModel` is the actual viewmodel for the page.

In this sample, both DataAnnotations and FluentValidation are used on `PageModel`-level; however, no validation is triggered and neither validator's code is executed.

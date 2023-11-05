class Shirt:
    def __init__(self) -> None:
        self.Id = 0
        self.Color = ""
        self.Design = ""

    def to_dict(self):
        return {
            'Id': self.Id,
            'Color': self.Color,
            'Design': self.Design
        }
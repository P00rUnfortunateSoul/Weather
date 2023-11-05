from ServiceResponse import ServiceResponse
from ShirtSeeder import ShirtSeeder
from Shirt import Shirt
from ShirtRepository import ShirtRepository

class ShirtService:
    def __init__(self) -> None:
        self.repo = ShirtRepository()

    async def GetShirts(self):
        try:
            response = ServiceResponse()
            response.Data = self.repo.get_shirts()
            response.Message = "Ok"
            response.Success = True
            return response
        except:
            response = ServiceResponse()
            response.Message = "Problem with accesing base of shirts"
            response.Success = False
            return response
        
    async def ChangeShirt(self, id: int, new_color, new_design):
        try:
            response = ServiceResponse()
            shirt = self.repo.get_shirt_by_id(id)
            if shirt:
                self.repo.update_shirt(id, new_color, new_design)
                response.Message = "Modified record"
                response.Success = True
            else:
                response.Message = "Shirt not found"
                response.Success = False
            return response
        except:
            response = ServiceResponse()
            response.Message = "Problem with modifing record in database"
            response.Success = False
            return response
        
    async def DeleteShirt(self, id: int):
        try:
            response = ServiceResponse()
            shirt = self.repo.get_shirt_by_id(id)
            if shirt:
                self.repo.delete_shirt(id)
                response.Message = "Record deleted"
                response.Success = True
            else:
                response.Message = "Shirt not found"
                response.Success = False  
            return response
        except:
            response = ServiceResponse()
            response.Message = "Problem with deleting record from database"
            response.Success = False
            return response

    async def AddShirt(self, color: str, design: str):
        try:
            response = ServiceResponse()
            shirt = Shirt()
            shirt.Color = color
            shirt.Design = design
            self.repo.create_shirt(shirt)
            response.Message = "Record added"
            response.Success = True
            return response
        except:
            response = ServiceResponse()
            response.Message = "Problem with adding record to database"
            response.Success = False
            return response
from ShirtService import ShirtService

class ShirtController:
    def __init__(self, service: ShirtService):
        self.service = service

    def getAllShirts(self):
        try:
            shirts = self.service.GetAllShirts()
            return shirts
        except Exception as e:
            print("Error getting shirts: {}".format(e))
            return []

    def addShirt(self, color, design):
        try:
            shirt = self.service.AddShirt(color, design)
            if shirt:
                return True
            else:
                return False
        except Exception as e:
            print("Error adding shirt: {}".format(e))
            return False

    def updateShirt(self, shirt_id, new_color, new_design):
        try:
            updated_shirt = self.service.UpdateShirt(shirt_id, new_color, new_design)
            if updated_shirt:
                return True
            else:
                return False
        except Exception as e:
            print("Error updating shirt: {}".format(e))
            return False

    def deleteShirt(self, shirt_id):
        try:
            deleted = self.service.DeleteShirt(shirt_id)
            return deleted
        except Exception as e:
            print("Error deleting shirt: {}".format(e))
            return False

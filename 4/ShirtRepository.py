from contextlib import contextmanager
from sqlalchemy import create_engine
from sqlalchemy.orm import sessionmaker
from Shirt import Shirt

class SessionManager:
    def __init__(self, db_url):
        self.engine = create_engine(db_url)
        self.Session = sessionmaker(bind=self.engine)

    @contextmanager
    def session_scope(self):
        session = self.Session()
        try:
            yield session
            session.commit()
        except Exception:
            session.rollback()
            raise
        finally:
            session.close()

class ShirtRepository:
    def __init__(self) -> None:
        self.session_man = SessionManager("postgresql://postgres:ulyana123@localhost:5432/pamiw4")

    def create_shirt(self, shirt):
        with self.session_man.session_scope() as session:
            session.add(shirt)

    def get_shirts(self):
        with self.session_man.session_scope() as session:
            return session.query(Shirt).all()
        
    def get_shirt_by_id(self, id):
        with self.session_man.session_scope() as session:
            return session.query(Shirt).filter(Shirt.Id == id).first()

    def update_shirt(self, id, new_color, new_design):
        with self.session_man.session_scope() as session:
            shirt = session.query(Shirt).filter(Shirt.Id == id).first()

            if shirt:
                shirt.Color = new_color
                shirt.Design = new_design

    def delete_shirt(self, id):
        with self.session_man.session_scope() as session:
            shirt = session.query(Shirt).filter(Shirt.Id == id).first()

            if shirt:
                session.delete(shirt)
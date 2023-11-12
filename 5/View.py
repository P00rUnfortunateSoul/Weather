from flask import Flask, render_template, request, redirect, url_for
from ShirtController import ShirtController
from ShirtService import ShirtService
import configparser

app = Flask(__name__)
controller = ShirtController(ShirtService())
app.config['DEBUG'] = True

config = configparser.ConfigParser()
config.read('config.ini')


@app.route(config['Routes']['index'])
def index():
    shirts = controller.getAllShirts()
    return render_template('index.html', shirts=shirts)


@app.route(config['Routes']['add_shirt'], methods=['POST'])
def add_shirt():
    if request.method == 'POST':
        color = request.form['color']
        design = request.form['text']
        success = controller.addShirt(color, design)
        if success:
            return redirect(url_for('index'))
        else:
            return "Error adding shirt"


@app.route(config['Routes']['update_shirt']+'/<int:shirt_id>', methods=['POST'])
def update_shirt(shirt_id):
    if request.method == 'POST':
        new_color = request.form['new_color']
        new_design = request.form['new_text']
        success = controller.updateShirt(shirt_id, new_color, new_design)
        if success:
            return redirect(url_for('index'))
        else:
            return "Error updating shirt"


@app.route(config['Routes']['delete_shirt']+'/<int:shirt_id>', methods=['POST'])
def delete_shirt(shirt_id):
    success = controller.deleteShirt(shirt_id)
    if success:
        return redirect(url_for('index'))
    else:
        return "Error deleting shirt"


if __name__ == '__main__':
    app.run()

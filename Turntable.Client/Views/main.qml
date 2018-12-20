import QtQuick 2.7
import QtQuick.Controls 2.0
import QtQuick.Layouts 1.3
import QtQuick.Controls.Material 2.0

ApplicationWindow {
    id: window
    visible: true
    width: 640
    height: 480
	title : app.title

	header: ToolBar {
	    id: header
        Material.foreground: "white"
		
		RowLayout {
            spacing: 20
            anchors.fill: parent

			TabBar {
                id: bar
                background: Rectangle {
                    color: Material.primary
                }
                Material.foreground: "#FFE0E0E0"
                Material.accent: "white"
                Layout.fillWidth: true

                TabButton {
                    text: qsTr("Home")
                }
                TabButton {
                    text: qsTr("Turntable")
                }
                TabButton {
                    text: qsTr("Locomotives")
                }
            }

			ToolButton {
                onClicked: optionsMenu.open()

                Menu {
                    id: optionsMenu
                    x: parent.width - width
                    transformOrigin: Menu.TopRight

                    MenuItem {
						text: qsTr("Connect/disconnect");
						/*
                        text: app.connected ? qsTr("Disconnect") : qsTr("Connect")
                        onTriggered: {
                            if (app.connected)
                                app.network.disconnectFromHost();
                            else {
                                connectionPopup.open();
                                connectionView.ipInput.forceActiveFocus();
                            }
                        }
						*/
                    }

                    MenuItem {
                        text: qsTr("About")
                        enabled: false
                    }

                    MenuItem {
                        text: qsTr("Exit")
                        onTriggered: {
                            Qt.quit();
                        }
                    }
                }
            }
		}
	}
}
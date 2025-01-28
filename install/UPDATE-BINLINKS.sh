#!/bin/bash

installationPath < backlog.cfg

sudo ln -sfn "${installationPath}/backlog" /usr/bin/backlog
sudo chmod -R a+r /usr/bin/backlog
sudo ln -sfn "${installationPath}/backlog.cfg" /usr/bin/backlog.cfg
sudo chmod -R a+r /usr/bin/backlog.cfg
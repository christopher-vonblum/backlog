#!/bin/bash

SCRIPT_DIR="$1"

chown -R "${USER}" "${SCRIPT_DIR}"

chmod -R a+rwx "${SCRIPT_DIR}"

echo -n "${SCRIPT_DIR}" > backlog.cfg

chmod -R a+rwx backlog.cfg

./UPDATE-BIN-LINKS.sh

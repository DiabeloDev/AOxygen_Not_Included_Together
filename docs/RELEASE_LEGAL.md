# Release Legal and License Boundary

**Audit date:** 2026-10-15  
**Release line:** PR #63 / planned 0.8.0.5  
**Status:** Legal preparation in progress; inherited non-code assets verified, remaining gates below

## Final upstream-tracking release

PR #63 is the final release intended to track the original upstream repository. The verified release ancestry is:

- `experiment`: `64a4dd6fa2870877868d13be034a3d8cf13f1f19`
- last imported upstream parent: `1c9d7226c7f9dbde7c303a11af4adf5fd5c2ffbb`
- upstream integration merge: `88e7f06cb3c2f1d3cabdc389778bb8c083061016`, dated 2026-10-05
- current audited `develop`: `d5a1326d7e5cfc816794644a2d1e597949b84f66`

The imported upstream parent and the downstream parent both contained the MIT License. Upstream changed to a restrictive source-available license on 2026-10-11. That restrictive-license commit is not an ancestor of the audited `develop` branch.

Future releases are intended to be an independent community-maintained project. Code published upstream after the license transition must not be incorporated automatically. Each proposed import requires compatible license evidence or written permission.

## Current compliance gates

- Preserve `LICENSE.md` and upstream attribution.
- Include `THIRD_PARTY_NOTICES.md` with every binary release.
- Preserve `ASSET_PROVENANCE.md` with the release. Every currently tracked image and asset bundle has been verified as identical to the last imported MIT upstream snapshot; re-review any asset added or modified after that baseline.
- Document permission for copied FUI helpers and gist-derived code, or replace them.
- Confirm the final package contains no ONI, Unity, publicized game, Steamworks.NET, or Steam SDK binaries.
- Address historical committed proprietary binaries through a separately approved history-remediation plan.
- Run a historical secret scan before rewriting public history.
- Build, inspect, and runtime-test the exact final commit and artifact.

Passing the technical test gate does not satisfy the legal/compliance gate, and passing this source audit does not verify a future package whose contents have not been inspected.

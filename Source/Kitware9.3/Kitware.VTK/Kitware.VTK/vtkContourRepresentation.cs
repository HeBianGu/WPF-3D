using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkContourRepresentation
	/// </summary>
	/// <remarks>
	///    represent the vtkContourWidget
	///
	/// The vtkContourRepresentation is a superclass for various types of
	/// representations for vtkContourWidget.
	///
	/// @par Managing contour points:
	/// The classes vtkContourRepresentationNode, vtkContourRepresentationInternals,
	/// and vtkContourRepresentationPoint manage the data structure used to represent
	/// nodes and points on a contour. A contour may contain several nodes and
	/// several additional points. Nodes are usually the result of user-clicked points
	/// on the contour. Additional points are created between nodes to generate a
	/// smooth curve using some Interpolator -- see the method \c SetLineInterpolator.
	///
	/// @par Managing contour points:
	/// \par
	/// The data structure stores both the world and display positions for every
	/// point. (This may seem like a duplication.) The default behaviour of this
	/// class is to use the WorldPosition to do all the math. Typically a point is
	/// added at a given display position. Its corresponding world position is
	/// computed using the point placer, and stored. Any query of the display
	/// position of a stored point is done via the Renderer, which computes the
	/// display position given a world position.
	///
	/// @par Managing contour points:
	/// \par
	/// So why maintain the display position? Consider drawing a contour on a
	/// volume widget. You might want the contour to be located at a certain world
	/// position in the volume or you might want to be overlaid over the window
	/// like an Actor2D. The default behaviour of this class is to provide the
	/// former behaviour.
	///
	/// @par Managing contour points:
	/// \par
	/// To achieve the latter behaviour, override the methods that return the display
	/// position (to return the set display position instead of computing it from
	/// the world positions) and the method \c BuildLines() to interpolate lines
	/// using their display positions instead of world positions.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourWidget
	/// </seealso>
	// Token: 0x02000300 RID: 768
	public abstract class vtkContourRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008940 RID: 35136 RVA: 0x000C4217 File Offset: 0x000C2417
		static vtkContourRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkContourRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkContourRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008941 RID: 35137 RVA: 0x000C423F File Offset: 0x000C243F
		public vtkContourRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008942 RID: 35138 RVA: 0x000C424D File Offset: 0x000C244D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008943 RID: 35139
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_ActivateNode_01(HandleRef pThis, IntPtr displayPos);

		/// <summary>
		/// Given a display position, activate a node. The closest
		/// node within tolerance will be activated. If a node is
		/// activated, 1 will be returned, otherwise 0 will be
		/// returned.
		/// </summary>
		// Token: 0x06008944 RID: 35140 RVA: 0x000C4258 File Offset: 0x000C2458
		public virtual int ActivateNode(IntPtr displayPos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_ActivateNode_01(base.GetCppThis(), displayPos);
		}

		// Token: 0x06008945 RID: 35141
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_ActivateNode_02(HandleRef pThis, int X, int Y);

		/// <summary>
		/// Given a display position, activate a node. The closest
		/// node within tolerance will be activated. If a node is
		/// activated, 1 will be returned, otherwise 0 will be
		/// returned.
		/// </summary>
		// Token: 0x06008946 RID: 35142 RVA: 0x000C4278 File Offset: 0x000C2478
		public virtual int ActivateNode(int X, int Y)
		{
			return vtkContourRepresentation.vtkContourRepresentation_ActivateNode_02(base.GetCppThis(), X, Y);
		}

		// Token: 0x06008947 RID: 35143
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_AddIntermediatePointWorldPosition_03(HandleRef pThis, int n, IntPtr point);

		/// <summary>
		/// Add an intermediate point between node n and n+1
		/// (or n and 0 if n is the last node and the loop is closed).
		/// Returns 1 on success or 0 if n is out of range.
		/// </summary>
		// Token: 0x06008948 RID: 35144 RVA: 0x000C429C File Offset: 0x000C249C
		public virtual int AddIntermediatePointWorldPosition(int n, IntPtr point)
		{
			return vtkContourRepresentation.vtkContourRepresentation_AddIntermediatePointWorldPosition_03(base.GetCppThis(), n, point);
		}

		// Token: 0x06008949 RID: 35145
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_AddIntermediatePointWorldPosition_04(HandleRef pThis, int n, IntPtr point, long ptId);

		/// <summary>
		/// Add an intermediate point between node n and n+1
		/// (or n and 0 if n is the last node and the loop is closed).
		/// Returns 1 on success or 0 if n is out of range. The added point is
		/// assigned a ptId as supplied.
		/// </summary>
		// Token: 0x0600894A RID: 35146 RVA: 0x000C42C0 File Offset: 0x000C24C0
		public virtual int AddIntermediatePointWorldPosition(int n, IntPtr point, long ptId)
		{
			return vtkContourRepresentation.vtkContourRepresentation_AddIntermediatePointWorldPosition_04(base.GetCppThis(), n, point, ptId);
		}

		// Token: 0x0600894B RID: 35147
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_AddNodeAtDisplayPosition_05(HandleRef pThis, IntPtr displayPos);

		/// <summary>
		/// Add a node at a specific display position. This will be
		/// converted into a world position according to the current
		/// constraints of the point placer. Return 0 if a point could
		/// not be added, 1 otherwise.
		/// </summary>
		// Token: 0x0600894C RID: 35148 RVA: 0x000C42E4 File Offset: 0x000C24E4
		public virtual int AddNodeAtDisplayPosition(IntPtr displayPos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_AddNodeAtDisplayPosition_05(base.GetCppThis(), displayPos);
		}

		// Token: 0x0600894D RID: 35149
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_AddNodeAtDisplayPosition_06(HandleRef pThis, int X, int Y);

		/// <summary>
		/// Add a node at a specific display position. This will be
		/// converted into a world position according to the current
		/// constraints of the point placer. Return 0 if a point could
		/// not be added, 1 otherwise.
		/// </summary>
		// Token: 0x0600894E RID: 35150 RVA: 0x000C4304 File Offset: 0x000C2504
		public virtual int AddNodeAtDisplayPosition(int X, int Y)
		{
			return vtkContourRepresentation.vtkContourRepresentation_AddNodeAtDisplayPosition_06(base.GetCppThis(), X, Y);
		}

		// Token: 0x0600894F RID: 35151
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_AddNodeAtWorldPosition_07(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Add a node at a specific world position. Returns 0 if the
		/// node could not be added, 1 otherwise.
		/// </summary>
		// Token: 0x06008950 RID: 35152 RVA: 0x000C4328 File Offset: 0x000C2528
		public virtual int AddNodeAtWorldPosition(double x, double y, double z)
		{
			return vtkContourRepresentation.vtkContourRepresentation_AddNodeAtWorldPosition_07(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06008951 RID: 35153
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_AddNodeAtWorldPosition_08(HandleRef pThis, IntPtr worldPos);

		/// <summary>
		/// Add a node at a specific world position. Returns 0 if the
		/// node could not be added, 1 otherwise.
		/// </summary>
		// Token: 0x06008952 RID: 35154 RVA: 0x000C434C File Offset: 0x000C254C
		public virtual int AddNodeAtWorldPosition(IntPtr worldPos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_AddNodeAtWorldPosition_08(base.GetCppThis(), worldPos);
		}

		// Token: 0x06008953 RID: 35155
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_AddNodeAtWorldPosition_09(HandleRef pThis, IntPtr worldPos, IntPtr worldOrient);

		/// <summary>
		/// Add a node at a specific world position. Returns 0 if the
		/// node could not be added, 1 otherwise.
		/// </summary>
		// Token: 0x06008954 RID: 35156 RVA: 0x000C436C File Offset: 0x000C256C
		public virtual int AddNodeAtWorldPosition(IntPtr worldPos, IntPtr worldOrient)
		{
			return vtkContourRepresentation.vtkContourRepresentation_AddNodeAtWorldPosition_09(base.GetCppThis(), worldPos, worldOrient);
		}

		// Token: 0x06008955 RID: 35157
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_AddNodeOnContour_10(HandleRef pThis, int X, int Y);

		/// <summary>
		/// Given a specific X, Y pixel location, add a new node
		/// on the contour at this location.
		/// </summary>
		// Token: 0x06008956 RID: 35158 RVA: 0x000C4390 File Offset: 0x000C2590
		public virtual int AddNodeOnContour(int X, int Y)
		{
			return vtkContourRepresentation.vtkContourRepresentation_AddNodeOnContour_10(base.GetCppThis(), X, Y);
		}

		// Token: 0x06008957 RID: 35159
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_BuildRepresentation_11(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008958 RID: 35160 RVA: 0x000C43B1 File Offset: 0x000C25B1
		public override void BuildRepresentation()
		{
			vtkContourRepresentation.vtkContourRepresentation_BuildRepresentation_11(base.GetCppThis());
		}

		// Token: 0x06008959 RID: 35161
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_ClearAllNodes_12(HandleRef pThis);

		/// <summary>
		/// Delete all nodes.
		/// </summary>
		// Token: 0x0600895A RID: 35162 RVA: 0x000C43C0 File Offset: 0x000C25C0
		public virtual void ClearAllNodes()
		{
			vtkContourRepresentation.vtkContourRepresentation_ClearAllNodes_12(base.GetCppThis());
		}

		// Token: 0x0600895B RID: 35163
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_ClosedLoopOff_13(HandleRef pThis);

		/// <summary>
		/// Set / Get the ClosedLoop value. This ivar indicates whether the contour
		/// forms a closed loop.
		/// </summary>
		// Token: 0x0600895C RID: 35164 RVA: 0x000C43CF File Offset: 0x000C25CF
		public virtual void ClosedLoopOff()
		{
			vtkContourRepresentation.vtkContourRepresentation_ClosedLoopOff_13(base.GetCppThis());
		}

		// Token: 0x0600895D RID: 35165
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_ClosedLoopOn_14(HandleRef pThis);

		/// <summary>
		/// Set / Get the ClosedLoop value. This ivar indicates whether the contour
		/// forms a closed loop.
		/// </summary>
		// Token: 0x0600895E RID: 35166 RVA: 0x000C43DE File Offset: 0x000C25DE
		public virtual void ClosedLoopOn()
		{
			vtkContourRepresentation.vtkContourRepresentation_ClosedLoopOn_14(base.GetCppThis());
		}

		// Token: 0x0600895F RID: 35167
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_ComputeInteractionState_15(HandleRef pThis, int X, int Y, int modified);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008960 RID: 35168 RVA: 0x000C43F0 File Offset: 0x000C25F0
		public override int ComputeInteractionState(int X, int Y, int modified)
		{
			return vtkContourRepresentation.vtkContourRepresentation_ComputeInteractionState_15(base.GetCppThis(), X, Y, modified);
		}

		// Token: 0x06008961 RID: 35169
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_DeleteActiveNode_16(HandleRef pThis);

		/// <summary>
		/// Delete the active node. Returns 1 on success or 0 if
		/// the active node did not indicate a valid node.
		/// </summary>
		// Token: 0x06008962 RID: 35170 RVA: 0x000C4414 File Offset: 0x000C2614
		public virtual int DeleteActiveNode()
		{
			return vtkContourRepresentation.vtkContourRepresentation_DeleteActiveNode_16(base.GetCppThis());
		}

		// Token: 0x06008963 RID: 35171
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_DeleteLastNode_17(HandleRef pThis);

		/// <summary>
		/// Delete the last node. Returns 1 on success or 0 if
		/// there were not any nodes.
		/// </summary>
		// Token: 0x06008964 RID: 35172 RVA: 0x000C4434 File Offset: 0x000C2634
		public virtual int DeleteLastNode()
		{
			return vtkContourRepresentation.vtkContourRepresentation_DeleteLastNode_17(base.GetCppThis());
		}

		// Token: 0x06008965 RID: 35173
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_DeleteNthNode_18(HandleRef pThis, int n);

		/// <summary>
		/// Delete the nth node. Return 1 on success or 0 if n
		/// is out of range.
		/// </summary>
		// Token: 0x06008966 RID: 35174 RVA: 0x000C4454 File Offset: 0x000C2654
		public virtual int DeleteNthNode(int n)
		{
			return vtkContourRepresentation.vtkContourRepresentation_DeleteNthNode_18(base.GetCppThis(), n);
		}

		// Token: 0x06008967 RID: 35175
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetActiveNodeDisplayPosition_19(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Get the display position of the active node. Will return
		/// 0 if there is no active node, or 1 otherwise.
		/// </summary>
		// Token: 0x06008968 RID: 35176 RVA: 0x000C4474 File Offset: 0x000C2674
		public virtual int GetActiveNodeDisplayPosition(IntPtr pos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetActiveNodeDisplayPosition_19(base.GetCppThis(), pos);
		}

		// Token: 0x06008969 RID: 35177
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetActiveNodeSelected_20(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the active or nth node is selected.
		/// </summary>
		// Token: 0x0600896A RID: 35178 RVA: 0x000C4494 File Offset: 0x000C2694
		public virtual int GetActiveNodeSelected()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetActiveNodeSelected_20(base.GetCppThis());
		}

		// Token: 0x0600896B RID: 35179
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetActiveNodeWorldOrientation_21(HandleRef pThis, IntPtr orient);

		/// <summary>
		/// Get the world orientation of the active node. Will return
		/// 0 if there is no active node, or 1 otherwise.
		/// </summary>
		// Token: 0x0600896C RID: 35180 RVA: 0x000C44B4 File Offset: 0x000C26B4
		public virtual int GetActiveNodeWorldOrientation(IntPtr orient)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetActiveNodeWorldOrientation_21(base.GetCppThis(), orient);
		}

		// Token: 0x0600896D RID: 35181
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetActiveNodeWorldPosition_22(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Get the world position of the active node. Will return
		/// 0 if there is no active node, or 1 otherwise.
		/// </summary>
		// Token: 0x0600896E RID: 35182 RVA: 0x000C44D4 File Offset: 0x000C26D4
		public virtual int GetActiveNodeWorldPosition(IntPtr pos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetActiveNodeWorldPosition_22(base.GetCppThis(), pos);
		}

		// Token: 0x0600896F RID: 35183
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetClosedLoop_23(HandleRef pThis);

		/// <summary>
		/// Set / Get the ClosedLoop value. This ivar indicates whether the contour
		/// forms a closed loop.
		/// </summary>
		// Token: 0x06008970 RID: 35184 RVA: 0x000C44F4 File Offset: 0x000C26F4
		public virtual int GetClosedLoop()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetClosedLoop_23(base.GetCppThis());
		}

		// Token: 0x06008971 RID: 35185
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourRepresentation_GetContourRepresentationAsPolyData_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the points in this contour as a vtkPolyData.
		/// </summary>
		// Token: 0x06008972 RID: 35186 RVA: 0x000C4514 File Offset: 0x000C2714
		public virtual vtkPolyData GetContourRepresentationAsPolyData()
		{
			vtkPolyData vtkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourRepresentation.vtkContourRepresentation_GetContourRepresentationAsPolyData_24(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyData = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyData.Register(null);
				}
			}
			return vtkPolyData;
		}

		// Token: 0x06008973 RID: 35187
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetCurrentOperation_25(HandleRef pThis);

		/// <summary>
		/// Set / get the current operation. The widget is either
		/// inactive, or it is being translated.
		/// </summary>
		// Token: 0x06008974 RID: 35188 RVA: 0x000C4584 File Offset: 0x000C2784
		public virtual int GetCurrentOperation()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetCurrentOperation_25(base.GetCppThis());
		}

		// Token: 0x06008975 RID: 35189
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetCurrentOperationMaxValue_26(HandleRef pThis);

		/// <summary>
		/// Set / get the current operation. The widget is either
		/// inactive, or it is being translated.
		/// </summary>
		// Token: 0x06008976 RID: 35190 RVA: 0x000C45A4 File Offset: 0x000C27A4
		public virtual int GetCurrentOperationMaxValue()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetCurrentOperationMaxValue_26(base.GetCppThis());
		}

		// Token: 0x06008977 RID: 35191
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetCurrentOperationMinValue_27(HandleRef pThis);

		/// <summary>
		/// Set / get the current operation. The widget is either
		/// inactive, or it is being translated.
		/// </summary>
		// Token: 0x06008978 RID: 35192 RVA: 0x000C45C4 File Offset: 0x000C27C4
		public virtual int GetCurrentOperationMinValue()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetCurrentOperationMinValue_27(base.GetCppThis());
		}

		// Token: 0x06008979 RID: 35193
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetIntermediatePointWorldPosition_28(HandleRef pThis, int n, int idx, IntPtr point);

		/// <summary>
		/// Get the world position of the intermediate point at
		/// index idx between nodes n and (n+1) (or n and 0 if
		/// n is the last node and the loop is closed). Returns
		/// 1 on success or 0 if n or idx are out of range.
		/// </summary>
		// Token: 0x0600897A RID: 35194 RVA: 0x000C45E4 File Offset: 0x000C27E4
		public virtual int GetIntermediatePointWorldPosition(int n, int idx, IntPtr point)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetIntermediatePointWorldPosition_28(base.GetCppThis(), n, idx, point);
		}

		// Token: 0x0600897B RID: 35195
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourRepresentation_GetLineInterpolator_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / Get the Line Interpolator. The line interpolator
		/// is responsible for generating the line segments connecting
		/// nodes.
		/// </summary>
		// Token: 0x0600897C RID: 35196 RVA: 0x000C4608 File Offset: 0x000C2808
		public virtual vtkContourLineInterpolator GetLineInterpolator()
		{
			vtkContourLineInterpolator vtkContourLineInterpolator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourRepresentation.vtkContourRepresentation_GetLineInterpolator_29(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourLineInterpolator = (vtkContourLineInterpolator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourLineInterpolator.Register(null);
				}
			}
			return vtkContourLineInterpolator;
		}

		// Token: 0x0600897D RID: 35197
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_GetNodePolyData_30(HandleRef pThis, HandleRef poly);

		/// <summary>
		/// Get the nodes and not the intermediate points in this
		/// contour as a vtkPolyData.
		/// </summary>
		// Token: 0x0600897E RID: 35198 RVA: 0x000C4678 File Offset: 0x000C2878
		public void GetNodePolyData(vtkPolyData poly)
		{
			vtkContourRepresentation.vtkContourRepresentation_GetNodePolyData_30(base.GetCppThis(), (poly == null) ? default(HandleRef) : poly.GetCppThis());
		}

		// Token: 0x0600897F RID: 35199
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetNthNodeDisplayPosition_31(HandleRef pThis, int n, IntPtr pos);

		/// <summary>
		/// Get the nth node's display position. Will return
		/// 1 on success, or 0 if there are not at least
		/// (n+1) nodes (0 based counting).
		/// </summary>
		// Token: 0x06008980 RID: 35200 RVA: 0x000C46A8 File Offset: 0x000C28A8
		public virtual int GetNthNodeDisplayPosition(int n, IntPtr pos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetNthNodeDisplayPosition_31(base.GetCppThis(), n, pos);
		}

		// Token: 0x06008981 RID: 35201
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetNthNodeSelected_32(HandleRef pThis, int arg0);

		/// <summary>
		/// Set/Get whether the active or nth node is selected.
		/// </summary>
		// Token: 0x06008982 RID: 35202 RVA: 0x000C46CC File Offset: 0x000C28CC
		public virtual int GetNthNodeSelected(int arg0)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetNthNodeSelected_32(base.GetCppThis(), arg0);
		}

		// Token: 0x06008983 RID: 35203
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetNthNodeSlope_33(HandleRef pThis, int idx, IntPtr slope);

		/// <summary>
		/// Get the nth node's slope. Will return
		/// 1 on success, or 0 if there are not at least
		/// (n+1) nodes (0 based counting).
		/// </summary>
		// Token: 0x06008984 RID: 35204 RVA: 0x000C46EC File Offset: 0x000C28EC
		public virtual int GetNthNodeSlope(int idx, IntPtr slope)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetNthNodeSlope_33(base.GetCppThis(), idx, slope);
		}

		// Token: 0x06008985 RID: 35205
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetNthNodeWorldOrientation_34(HandleRef pThis, int n, IntPtr orient);

		/// <summary>
		/// Get the nth node's world orientation. Will return
		/// 1 on success, or 0 if there are not at least
		/// (n+1) nodes (0 based counting).
		/// </summary>
		// Token: 0x06008986 RID: 35206 RVA: 0x000C4710 File Offset: 0x000C2910
		public virtual int GetNthNodeWorldOrientation(int n, IntPtr orient)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetNthNodeWorldOrientation_34(base.GetCppThis(), n, orient);
		}

		// Token: 0x06008987 RID: 35207
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetNthNodeWorldPosition_35(HandleRef pThis, int n, IntPtr pos);

		/// <summary>
		/// Get the nth node's world position. Will return
		/// 1 on success, or 0 if there are not at least
		/// (n+1) nodes (0 based counting).
		/// </summary>
		// Token: 0x06008988 RID: 35208 RVA: 0x000C4734 File Offset: 0x000C2934
		public virtual int GetNthNodeWorldPosition(int n, IntPtr pos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetNthNodeWorldPosition_35(base.GetCppThis(), n, pos);
		}

		// Token: 0x06008989 RID: 35209
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourRepresentation_GetNumberOfGenerationsFromBase_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600898A RID: 35210 RVA: 0x000C4758 File Offset: 0x000C2958
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetNumberOfGenerationsFromBase_36(base.GetCppThis(), type);
		}

		// Token: 0x0600898B RID: 35211
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkContourRepresentation_GetNumberOfGenerationsFromBaseType_37([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600898C RID: 35212 RVA: 0x000C4778 File Offset: 0x000C2978
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetNumberOfGenerationsFromBaseType_37(type);
		}

		// Token: 0x0600898D RID: 35213
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetNumberOfIntermediatePoints_38(HandleRef pThis, int n);

		/// <summary>
		/// Get the nth node's slope. Will return
		/// 1 on success, or 0 if there are not at least
		/// (n+1) nodes (0 based counting).
		/// </summary>
		// Token: 0x0600898E RID: 35214 RVA: 0x000C4794 File Offset: 0x000C2994
		public virtual int GetNumberOfIntermediatePoints(int n)
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetNumberOfIntermediatePoints_38(base.GetCppThis(), n);
		}

		// Token: 0x0600898F RID: 35215
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetNumberOfNodes_39(HandleRef pThis);

		/// <summary>
		/// Get the number of nodes.
		/// </summary>
		// Token: 0x06008990 RID: 35216 RVA: 0x000C47B4 File Offset: 0x000C29B4
		public virtual int GetNumberOfNodes()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetNumberOfNodes_39(base.GetCppThis());
		}

		// Token: 0x06008991 RID: 35217
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetPixelTolerance_40(HandleRef pThis);

		/// <summary>
		/// The tolerance to use when calculations are performed in
		/// display coordinates
		/// </summary>
		// Token: 0x06008992 RID: 35218 RVA: 0x000C47D4 File Offset: 0x000C29D4
		public virtual int GetPixelTolerance()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetPixelTolerance_40(base.GetCppThis());
		}

		// Token: 0x06008993 RID: 35219
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetPixelToleranceMaxValue_41(HandleRef pThis);

		/// <summary>
		/// The tolerance to use when calculations are performed in
		/// display coordinates
		/// </summary>
		// Token: 0x06008994 RID: 35220 RVA: 0x000C47F4 File Offset: 0x000C29F4
		public virtual int GetPixelToleranceMaxValue()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetPixelToleranceMaxValue_41(base.GetCppThis());
		}

		// Token: 0x06008995 RID: 35221
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetPixelToleranceMinValue_42(HandleRef pThis);

		/// <summary>
		/// The tolerance to use when calculations are performed in
		/// display coordinates
		/// </summary>
		// Token: 0x06008996 RID: 35222 RVA: 0x000C4814 File Offset: 0x000C2A14
		public virtual int GetPixelToleranceMinValue()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetPixelToleranceMinValue_42(base.GetCppThis());
		}

		// Token: 0x06008997 RID: 35223
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourRepresentation_GetPointPlacer_43(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get the current operation. The widget is either
		/// inactive, or it is being translated.
		/// </summary>
		// Token: 0x06008998 RID: 35224 RVA: 0x000C4834 File Offset: 0x000C2A34
		public virtual vtkPointPlacer GetPointPlacer()
		{
			vtkPointPlacer vtkPointPlacer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourRepresentation.vtkContourRepresentation_GetPointPlacer_43(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPointPlacer = (vtkPointPlacer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPointPlacer.Register(null);
				}
			}
			return vtkPointPlacer;
		}

		// Token: 0x06008999 RID: 35225
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_GetShowSelectedNodes_44(HandleRef pThis);

		/// <summary>
		/// A flag to indicate whether to show the Selected nodes
		/// Default is to set it to false.
		/// </summary>
		// Token: 0x0600899A RID: 35226 RVA: 0x000C48A4 File Offset: 0x000C2AA4
		public virtual int GetShowSelectedNodes()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetShowSelectedNodes_44(base.GetCppThis());
		}

		// Token: 0x0600899B RID: 35227
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkContourRepresentation_GetWorldTolerance_45(HandleRef pThis);

		/// <summary>
		/// The tolerance to use when calculations are performed in
		/// world coordinates
		/// </summary>
		// Token: 0x0600899C RID: 35228 RVA: 0x000C48C4 File Offset: 0x000C2AC4
		public virtual double GetWorldTolerance()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetWorldTolerance_45(base.GetCppThis());
		}

		// Token: 0x0600899D RID: 35229
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkContourRepresentation_GetWorldToleranceMaxValue_46(HandleRef pThis);

		/// <summary>
		/// The tolerance to use when calculations are performed in
		/// world coordinates
		/// </summary>
		// Token: 0x0600899E RID: 35230 RVA: 0x000C48E4 File Offset: 0x000C2AE4
		public virtual double GetWorldToleranceMaxValue()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetWorldToleranceMaxValue_46(base.GetCppThis());
		}

		// Token: 0x0600899F RID: 35231
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkContourRepresentation_GetWorldToleranceMinValue_47(HandleRef pThis);

		/// <summary>
		/// The tolerance to use when calculations are performed in
		/// world coordinates
		/// </summary>
		// Token: 0x060089A0 RID: 35232 RVA: 0x000C4904 File Offset: 0x000C2B04
		public virtual double GetWorldToleranceMinValue()
		{
			return vtkContourRepresentation.vtkContourRepresentation_GetWorldToleranceMinValue_47(base.GetCppThis());
		}

		// Token: 0x060089A1 RID: 35233
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_HasTranslucentPolygonalGeometry_48(HandleRef pThis);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x060089A2 RID: 35234 RVA: 0x000C4924 File Offset: 0x000C2B24
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkContourRepresentation.vtkContourRepresentation_HasTranslucentPolygonalGeometry_48(base.GetCppThis());
		}

		// Token: 0x060089A3 RID: 35235
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_IsA_49(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x060089A4 RID: 35236 RVA: 0x000C4944 File Offset: 0x000C2B44
		public override int IsA(string type)
		{
			return vtkContourRepresentation.vtkContourRepresentation_IsA_49(base.GetCppThis(), type);
		}

		// Token: 0x060089A5 RID: 35237
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_IsTypeOf_50([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x060089A6 RID: 35238 RVA: 0x000C4964 File Offset: 0x000C2B64
		public new static int IsTypeOf(string type)
		{
			return vtkContourRepresentation.vtkContourRepresentation_IsTypeOf_50(type);
		}

		// Token: 0x060089A7 RID: 35239
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourRepresentation_NewInstance_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x060089A8 RID: 35240 RVA: 0x000C4980 File Offset: 0x000C2B80
		public new vtkContourRepresentation NewInstance()
		{
			vtkContourRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourRepresentation.vtkContourRepresentation_NewInstance_51(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkContourRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060089A9 RID: 35241
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_ReleaseGraphicsResources_52(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x060089AA RID: 35242 RVA: 0x000C49DC File Offset: 0x000C2BDC
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkContourRepresentation.vtkContourRepresentation_ReleaseGraphicsResources_52(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x060089AB RID: 35243
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_RenderOpaqueGeometry_53(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x060089AC RID: 35244 RVA: 0x000C4A0C File Offset: 0x000C2C0C
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkContourRepresentation.vtkContourRepresentation_RenderOpaqueGeometry_53(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060089AD RID: 35245
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_RenderOverlay_54(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x060089AE RID: 35246 RVA: 0x000C4A40 File Offset: 0x000C2C40
		public override int RenderOverlay(vtkViewport viewport)
		{
			return vtkContourRepresentation.vtkContourRepresentation_RenderOverlay_54(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060089AF RID: 35247
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_RenderTranslucentPolygonalGeometry_55(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x060089B0 RID: 35248 RVA: 0x000C4A74 File Offset: 0x000C2C74
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkContourRepresentation.vtkContourRepresentation_RenderTranslucentPolygonalGeometry_55(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x060089B1 RID: 35249
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkContourRepresentation_SafeDownCast_56(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x060089B2 RID: 35250 RVA: 0x000C4AA8 File Offset: 0x000C2CA8
		public new static vtkContourRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkContourRepresentation vtkContourRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkContourRepresentation.vtkContourRepresentation_SafeDownCast_56((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkContourRepresentation = (vtkContourRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkContourRepresentation.Register(null);
				}
			}
			return vtkContourRepresentation;
		}

		// Token: 0x060089B3 RID: 35251
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_SetActiveNodeToDisplayPosition_57(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Move the active node based on a specified display position.
		/// The display position will be converted into a world
		/// position. If the new position is not valid or there is
		/// no active node, a 0 will be returned. Otherwise, on
		/// success a 1 will be returned.
		/// </summary>
		// Token: 0x060089B4 RID: 35252 RVA: 0x000C4B28 File Offset: 0x000C2D28
		public virtual int SetActiveNodeToDisplayPosition(IntPtr pos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetActiveNodeToDisplayPosition_57(base.GetCppThis(), pos);
		}

		// Token: 0x060089B5 RID: 35253
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_SetActiveNodeToDisplayPosition_58(HandleRef pThis, int X, int Y);

		/// <summary>
		/// Move the active node based on a specified display position.
		/// The display position will be converted into a world
		/// position. If the new position is not valid or there is
		/// no active node, a 0 will be returned. Otherwise, on
		/// success a 1 will be returned.
		/// </summary>
		// Token: 0x060089B6 RID: 35254 RVA: 0x000C4B48 File Offset: 0x000C2D48
		public virtual int SetActiveNodeToDisplayPosition(int X, int Y)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetActiveNodeToDisplayPosition_58(base.GetCppThis(), X, Y);
		}

		// Token: 0x060089B7 RID: 35255
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_SetActiveNodeToWorldPosition_59(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Given a display position, activate a node. The closest
		/// node within tolerance will be activated. If a node is
		/// activated, 1 will be returned, otherwise 0 will be
		/// returned.
		/// </summary>
		// Token: 0x060089B8 RID: 35256 RVA: 0x000C4B6C File Offset: 0x000C2D6C
		public virtual int SetActiveNodeToWorldPosition(IntPtr pos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetActiveNodeToWorldPosition_59(base.GetCppThis(), pos);
		}

		// Token: 0x060089B9 RID: 35257
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_SetActiveNodeToWorldPosition_60(HandleRef pThis, IntPtr pos, IntPtr orient);

		/// <summary>
		/// Given a display position, activate a node. The closest
		/// node within tolerance will be activated. If a node is
		/// activated, 1 will be returned, otherwise 0 will be
		/// returned.
		/// </summary>
		// Token: 0x060089BA RID: 35258 RVA: 0x000C4B8C File Offset: 0x000C2D8C
		public virtual int SetActiveNodeToWorldPosition(IntPtr pos, IntPtr orient)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetActiveNodeToWorldPosition_60(base.GetCppThis(), pos, orient);
		}

		// Token: 0x060089BB RID: 35259
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_SetClosedLoop_61(HandleRef pThis, int val);

		/// <summary>
		/// Set / Get the ClosedLoop value. This ivar indicates whether the contour
		/// forms a closed loop.
		/// </summary>
		// Token: 0x060089BC RID: 35260 RVA: 0x000C4BAD File Offset: 0x000C2DAD
		public void SetClosedLoop(int val)
		{
			vtkContourRepresentation.vtkContourRepresentation_SetClosedLoop_61(base.GetCppThis(), val);
		}

		// Token: 0x060089BD RID: 35261
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_SetCurrentOperation_62(HandleRef pThis, int _arg);

		/// <summary>
		/// Set / get the current operation. The widget is either
		/// inactive, or it is being translated.
		/// </summary>
		// Token: 0x060089BE RID: 35262 RVA: 0x000C4BBD File Offset: 0x000C2DBD
		public virtual void SetCurrentOperation(int _arg)
		{
			vtkContourRepresentation.vtkContourRepresentation_SetCurrentOperation_62(base.GetCppThis(), _arg);
		}

		// Token: 0x060089BF RID: 35263
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_SetCurrentOperationToInactive_63(HandleRef pThis);

		/// <summary>
		/// Set / get the current operation. The widget is either
		/// inactive, or it is being translated.
		/// </summary>
		// Token: 0x060089C0 RID: 35264 RVA: 0x000C4BCD File Offset: 0x000C2DCD
		public void SetCurrentOperationToInactive()
		{
			vtkContourRepresentation.vtkContourRepresentation_SetCurrentOperationToInactive_63(base.GetCppThis());
		}

		// Token: 0x060089C1 RID: 35265
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_SetCurrentOperationToScale_64(HandleRef pThis);

		/// <summary>
		/// Set / get the current operation. The widget is either
		/// inactive, or it is being translated.
		/// </summary>
		// Token: 0x060089C2 RID: 35266 RVA: 0x000C4BDC File Offset: 0x000C2DDC
		public void SetCurrentOperationToScale()
		{
			vtkContourRepresentation.vtkContourRepresentation_SetCurrentOperationToScale_64(base.GetCppThis());
		}

		// Token: 0x060089C3 RID: 35267
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_SetCurrentOperationToShift_65(HandleRef pThis);

		/// <summary>
		/// Set / get the current operation. The widget is either
		/// inactive, or it is being translated.
		/// </summary>
		// Token: 0x060089C4 RID: 35268 RVA: 0x000C4BEB File Offset: 0x000C2DEB
		public void SetCurrentOperationToShift()
		{
			vtkContourRepresentation.vtkContourRepresentation_SetCurrentOperationToShift_65(base.GetCppThis());
		}

		// Token: 0x060089C5 RID: 35269
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_SetCurrentOperationToTranslate_66(HandleRef pThis);

		/// <summary>
		/// Set / get the current operation. The widget is either
		/// inactive, or it is being translated.
		/// </summary>
		// Token: 0x060089C6 RID: 35270 RVA: 0x000C4BFA File Offset: 0x000C2DFA
		public void SetCurrentOperationToTranslate()
		{
			vtkContourRepresentation.vtkContourRepresentation_SetCurrentOperationToTranslate_66(base.GetCppThis());
		}

		// Token: 0x060089C7 RID: 35271
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_SetLineInterpolator_67(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / Get the Line Interpolator. The line interpolator
		/// is responsible for generating the line segments connecting
		/// nodes.
		/// </summary>
		// Token: 0x060089C8 RID: 35272 RVA: 0x000C4C0C File Offset: 0x000C2E0C
		public void SetLineInterpolator(vtkContourLineInterpolator arg0)
		{
			vtkContourRepresentation.vtkContourRepresentation_SetLineInterpolator_67(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060089C9 RID: 35273
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_SetNthNodeDisplayPosition_68(HandleRef pThis, int n, int X, int Y);

		/// <summary>
		/// Set the nth node's display position. Display position
		/// will be converted into world position according to the
		/// constraints of the point placer. Will return
		/// 1 on success, or 0 if there are not at least
		/// (n+1) nodes (0 based counting) or the world position
		/// is not valid.
		/// </summary>
		// Token: 0x060089CA RID: 35274 RVA: 0x000C4C3C File Offset: 0x000C2E3C
		public virtual int SetNthNodeDisplayPosition(int n, int X, int Y)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetNthNodeDisplayPosition_68(base.GetCppThis(), n, X, Y);
		}

		// Token: 0x060089CB RID: 35275
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_SetNthNodeDisplayPosition_69(HandleRef pThis, int n, IntPtr pos);

		/// <summary>
		/// Set the nth node's display position. Display position
		/// will be converted into world position according to the
		/// constraints of the point placer. Will return
		/// 1 on success, or 0 if there are not at least
		/// (n+1) nodes (0 based counting) or the world position
		/// is not valid.
		/// </summary>
		// Token: 0x060089CC RID: 35276 RVA: 0x000C4C60 File Offset: 0x000C2E60
		public virtual int SetNthNodeDisplayPosition(int n, IntPtr pos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetNthNodeDisplayPosition_69(base.GetCppThis(), n, pos);
		}

		// Token: 0x060089CD RID: 35277
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_SetNthNodeSelected_70(HandleRef pThis, int arg0);

		/// <summary>
		/// Set/Get whether the active or nth node is selected.
		/// </summary>
		// Token: 0x060089CE RID: 35278 RVA: 0x000C4C84 File Offset: 0x000C2E84
		public virtual int SetNthNodeSelected(int arg0)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetNthNodeSelected_70(base.GetCppThis(), arg0);
		}

		// Token: 0x060089CF RID: 35279
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_SetNthNodeWorldPosition_71(HandleRef pThis, int n, IntPtr pos);

		/// <summary>
		/// Set the nth node's world position. Will return
		/// 1 on success, or 0 if there are not at least
		/// (n+1) nodes (0 based counting) or the world
		/// position is not valid according to the point
		/// placer.
		/// </summary>
		// Token: 0x060089D0 RID: 35280 RVA: 0x000C4CA4 File Offset: 0x000C2EA4
		public virtual int SetNthNodeWorldPosition(int n, IntPtr pos)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetNthNodeWorldPosition_71(base.GetCppThis(), n, pos);
		}

		// Token: 0x060089D1 RID: 35281
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_SetNthNodeWorldPosition_72(HandleRef pThis, int n, IntPtr pos, IntPtr orient);

		/// <summary>
		/// Set the nth node's world position. Will return
		/// 1 on success, or 0 if there are not at least
		/// (n+1) nodes (0 based counting) or the world
		/// position is not valid according to the point
		/// placer.
		/// </summary>
		// Token: 0x060089D2 RID: 35282 RVA: 0x000C4CC8 File Offset: 0x000C2EC8
		public virtual int SetNthNodeWorldPosition(int n, IntPtr pos, IntPtr orient)
		{
			return vtkContourRepresentation.vtkContourRepresentation_SetNthNodeWorldPosition_72(base.GetCppThis(), n, pos, orient);
		}

		// Token: 0x060089D3 RID: 35283
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_SetPixelTolerance_73(HandleRef pThis, int _arg);

		/// <summary>
		/// The tolerance to use when calculations are performed in
		/// display coordinates
		/// </summary>
		// Token: 0x060089D4 RID: 35284 RVA: 0x000C4CEA File Offset: 0x000C2EEA
		public virtual void SetPixelTolerance(int _arg)
		{
			vtkContourRepresentation.vtkContourRepresentation_SetPixelTolerance_73(base.GetCppThis(), _arg);
		}

		// Token: 0x060089D5 RID: 35285
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_SetPointPlacer_74(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / get the current operation. The widget is either
		/// inactive, or it is being translated.
		/// </summary>
		// Token: 0x060089D6 RID: 35286 RVA: 0x000C4CFC File Offset: 0x000C2EFC
		public void SetPointPlacer(vtkPointPlacer arg0)
		{
			vtkContourRepresentation.vtkContourRepresentation_SetPointPlacer_74(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060089D7 RID: 35287
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_SetRebuildLocator_75(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get the nodes and not the intermediate points in this
		/// contour as a vtkPolyData.
		/// </summary>
		// Token: 0x060089D8 RID: 35288 RVA: 0x000C4D2B File Offset: 0x000C2F2B
		public virtual void SetRebuildLocator(bool _arg)
		{
			vtkContourRepresentation.vtkContourRepresentation_SetRebuildLocator_75(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060089D9 RID: 35289
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_SetShowSelectedNodes_76(HandleRef pThis, int arg0);

		/// <summary>
		/// A flag to indicate whether to show the Selected nodes
		/// Default is to set it to false.
		/// </summary>
		// Token: 0x060089DA RID: 35290 RVA: 0x000C4D43 File Offset: 0x000C2F43
		public virtual void SetShowSelectedNodes(int arg0)
		{
			vtkContourRepresentation.vtkContourRepresentation_SetShowSelectedNodes_76(base.GetCppThis(), arg0);
		}

		// Token: 0x060089DB RID: 35291
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_SetWorldTolerance_77(HandleRef pThis, double _arg);

		/// <summary>
		/// The tolerance to use when calculations are performed in
		/// world coordinates
		/// </summary>
		// Token: 0x060089DC RID: 35292 RVA: 0x000C4D53 File Offset: 0x000C2F53
		public virtual void SetWorldTolerance(double _arg)
		{
			vtkContourRepresentation.vtkContourRepresentation_SetWorldTolerance_77(base.GetCppThis(), _arg);
		}

		// Token: 0x060089DD RID: 35293
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_ShowSelectedNodesOff_78(HandleRef pThis);

		/// <summary>
		/// A flag to indicate whether to show the Selected nodes
		/// Default is to set it to false.
		/// </summary>
		// Token: 0x060089DE RID: 35294 RVA: 0x000C4D63 File Offset: 0x000C2F63
		public virtual void ShowSelectedNodesOff()
		{
			vtkContourRepresentation.vtkContourRepresentation_ShowSelectedNodesOff_78(base.GetCppThis());
		}

		// Token: 0x060089DF RID: 35295
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_ShowSelectedNodesOn_79(HandleRef pThis);

		/// <summary>
		/// A flag to indicate whether to show the Selected nodes
		/// Default is to set it to false.
		/// </summary>
		// Token: 0x060089E0 RID: 35296 RVA: 0x000C4D72 File Offset: 0x000C2F72
		public virtual void ShowSelectedNodesOn()
		{
			vtkContourRepresentation.vtkContourRepresentation_ShowSelectedNodesOn_79(base.GetCppThis());
		}

		// Token: 0x060089E1 RID: 35297
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_StartWidgetInteraction_80(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060089E2 RID: 35298 RVA: 0x000C4D81 File Offset: 0x000C2F81
		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkContourRepresentation.vtkContourRepresentation_StartWidgetInteraction_80(base.GetCppThis(), e);
		}

		// Token: 0x060089E3 RID: 35299
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkContourRepresentation_ToggleActiveNodeSelected_81(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the active or nth node is selected.
		/// </summary>
		// Token: 0x060089E4 RID: 35300 RVA: 0x000C4D94 File Offset: 0x000C2F94
		public virtual int ToggleActiveNodeSelected()
		{
			return vtkContourRepresentation.vtkContourRepresentation_ToggleActiveNodeSelected_81(base.GetCppThis());
		}

		// Token: 0x060089E5 RID: 35301
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkContourRepresentation_WidgetInteraction_82(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x060089E6 RID: 35302 RVA: 0x000C4DB3 File Offset: 0x000C2FB3
		public override void WidgetInteraction(IntPtr e)
		{
			vtkContourRepresentation.vtkContourRepresentation_WidgetInteraction_82(base.GetCppThis(), e);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B97 RID: 2967
		public new const string MRFullTypeName = "Kitware.VTK.vtkContourRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B98 RID: 2968
		public new static readonly string MRClassNameKey = "class vtkContourRepresentation";

		/// <summary>
		/// The tolerance to use when calculations are performed in
		/// world coordinates
		/// </summary>
		// Token: 0x02000301 RID: 769
		public enum Nearby_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000B9A RID: 2970
			Nearby = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000B9B RID: 2971
			Outside = 0
		}

		/// <summary>
		/// The tolerance to use when calculations are performed in
		/// world coordinates
		/// </summary>
		// Token: 0x02000302 RID: 770
		public enum Inactive_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000B9D RID: 2973
			Inactive,
			/// <summary>enum member</summary>
			// Token: 0x04000B9E RID: 2974
			Scale = 3,
			/// <summary>enum member</summary>
			// Token: 0x04000B9F RID: 2975
			Shift = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000BA0 RID: 2976
			Translate = 1
		}
	}
}

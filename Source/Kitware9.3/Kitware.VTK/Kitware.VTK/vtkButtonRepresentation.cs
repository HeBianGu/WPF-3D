using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkButtonRepresentation
	/// </summary>
	/// <remarks>
	///    abstract class defines the representation for a vtkButtonWidget
	///
	/// This abstract class is used to specify how the vtkButtonWidget should
	/// interact with representations of the vtkButtonWidget. This class may be
	/// subclassed so that alternative representations can be created. The class
	/// defines an API, and a default implementation, that the vtkButtonWidget
	/// interacts with to render itself in the scene.
	///
	/// The vtkButtonWidget assumes an n-state button so that traversal methods
	/// are available for changing, querying and manipulating state. Derived
	/// classed determine the actual appearance. The state is represented by an
	/// integral value 0&lt;=state&lt;numStates.
	///
	/// To use this representation, always begin by specifying the number of states.
	/// Then follow with the necessary information to represent each state (done through
	/// a subclass API).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkButtonWidget
	/// </seealso>
	// Token: 0x020002DB RID: 731
	public abstract class vtkButtonRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008403 RID: 33795 RVA: 0x000BC993 File Offset: 0x000BAB93
		static vtkButtonRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkButtonRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkButtonRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008404 RID: 33796 RVA: 0x000BC9BB File Offset: 0x000BABBB
		public vtkButtonRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008405 RID: 33797 RVA: 0x000BC9C9 File Offset: 0x000BABC9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008406 RID: 33798
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkButtonRepresentation_GetHighlightState_01(HandleRef pThis);

		/// <summary>
		/// These methods control the appearance of the button as it is being
		/// interacted with. Subclasses will behave differently depending on their
		/// particulars.  HighlightHovering is used when the mouse pointer moves
		/// over the button. HighlightSelecting is set when the button is selected.
		/// Otherwise, the HighlightNormal is used. The Highlight() method will throw
		/// a vtkCommand::HighlightEvent.
		/// </summary>
		// Token: 0x06008407 RID: 33799 RVA: 0x000BC9D4 File Offset: 0x000BABD4
		public virtual int GetHighlightState()
		{
			return vtkButtonRepresentation.vtkButtonRepresentation_GetHighlightState_01(base.GetCppThis());
		}

		// Token: 0x06008408 RID: 33800
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkButtonRepresentation_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008409 RID: 33801 RVA: 0x000BC9F4 File Offset: 0x000BABF4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkButtonRepresentation.vtkButtonRepresentation_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600840A RID: 33802
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkButtonRepresentation_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600840B RID: 33803 RVA: 0x000BCA14 File Offset: 0x000BAC14
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkButtonRepresentation.vtkButtonRepresentation_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600840C RID: 33804
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkButtonRepresentation_GetNumberOfStatesMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Retrieve the current button state.
		/// </summary>
		// Token: 0x0600840D RID: 33805 RVA: 0x000BCA30 File Offset: 0x000BAC30
		public virtual int GetNumberOfStatesMaxValue()
		{
			return vtkButtonRepresentation.vtkButtonRepresentation_GetNumberOfStatesMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0600840E RID: 33806
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkButtonRepresentation_GetNumberOfStatesMinValue_05(HandleRef pThis);

		/// <summary>
		/// Retrieve the current button state.
		/// </summary>
		// Token: 0x0600840F RID: 33807 RVA: 0x000BCA50 File Offset: 0x000BAC50
		public virtual int GetNumberOfStatesMinValue()
		{
			return vtkButtonRepresentation.vtkButtonRepresentation_GetNumberOfStatesMinValue_05(base.GetCppThis());
		}

		// Token: 0x06008410 RID: 33808
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkButtonRepresentation_GetState_06(HandleRef pThis);

		/// <summary>
		/// Retrieve the current button state.
		/// </summary>
		// Token: 0x06008411 RID: 33809 RVA: 0x000BCA70 File Offset: 0x000BAC70
		public virtual int GetState()
		{
			return vtkButtonRepresentation.vtkButtonRepresentation_GetState_06(base.GetCppThis());
		}

		// Token: 0x06008412 RID: 33810
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonRepresentation_Highlight_07(HandleRef pThis, int arg0);

		/// <summary>
		/// These methods control the appearance of the button as it is being
		/// interacted with. Subclasses will behave differently depending on their
		/// particulars.  HighlightHovering is used when the mouse pointer moves
		/// over the button. HighlightSelecting is set when the button is selected.
		/// Otherwise, the HighlightNormal is used. The Highlight() method will throw
		/// a vtkCommand::HighlightEvent.
		/// </summary>
		// Token: 0x06008413 RID: 33811 RVA: 0x000BCA8F File Offset: 0x000BAC8F
		public override void Highlight(int arg0)
		{
			vtkButtonRepresentation.vtkButtonRepresentation_Highlight_07(base.GetCppThis(), arg0);
		}

		// Token: 0x06008414 RID: 33812
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkButtonRepresentation_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008415 RID: 33813 RVA: 0x000BCAA0 File Offset: 0x000BACA0
		public override int IsA(string type)
		{
			return vtkButtonRepresentation.vtkButtonRepresentation_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x06008416 RID: 33814
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkButtonRepresentation_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008417 RID: 33815 RVA: 0x000BCAC0 File Offset: 0x000BACC0
		public new static int IsTypeOf(string type)
		{
			return vtkButtonRepresentation.vtkButtonRepresentation_IsTypeOf_09(type);
		}

		// Token: 0x06008418 RID: 33816
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkButtonRepresentation_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x06008419 RID: 33817 RVA: 0x000BCADC File Offset: 0x000BACDC
		public new vtkButtonRepresentation NewInstance()
		{
			vtkButtonRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkButtonRepresentation.vtkButtonRepresentation_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkButtonRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600841A RID: 33818
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonRepresentation_NextState_11(HandleRef pThis);

		/// <summary>
		/// Manipulate the state. Note that the NextState() and PreviousState() methods
		/// use modulo traversal. The "state" integral value will be clamped within
		/// the possible state values (0&lt;=state&lt;NumberOfStates). Note that subclasses
		/// will override these methods in many cases.
		/// </summary>
		// Token: 0x0600841B RID: 33819 RVA: 0x000BCB36 File Offset: 0x000BAD36
		public virtual void NextState()
		{
			vtkButtonRepresentation.vtkButtonRepresentation_NextState_11(base.GetCppThis());
		}

		// Token: 0x0600841C RID: 33820
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonRepresentation_PreviousState_12(HandleRef pThis);

		/// <summary>
		/// Manipulate the state. Note that the NextState() and PreviousState() methods
		/// use modulo traversal. The "state" integral value will be clamped within
		/// the possible state values (0&lt;=state&lt;NumberOfStates). Note that subclasses
		/// will override these methods in many cases.
		/// </summary>
		// Token: 0x0600841D RID: 33821 RVA: 0x000BCB45 File Offset: 0x000BAD45
		public virtual void PreviousState()
		{
			vtkButtonRepresentation.vtkButtonRepresentation_PreviousState_12(base.GetCppThis());
		}

		// Token: 0x0600841E RID: 33822
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkButtonRepresentation_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for the class.
		/// </summary>
		// Token: 0x0600841F RID: 33823 RVA: 0x000BCB54 File Offset: 0x000BAD54
		public new static vtkButtonRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkButtonRepresentation vtkButtonRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkButtonRepresentation.vtkButtonRepresentation_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkButtonRepresentation = (vtkButtonRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkButtonRepresentation.Register(null);
				}
			}
			return vtkButtonRepresentation;
		}

		// Token: 0x06008420 RID: 33824
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonRepresentation_SetNumberOfStates_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Retrieve the current button state.
		/// </summary>
		// Token: 0x06008421 RID: 33825 RVA: 0x000BCBD3 File Offset: 0x000BADD3
		public virtual void SetNumberOfStates(int _arg)
		{
			vtkButtonRepresentation.vtkButtonRepresentation_SetNumberOfStates_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06008422 RID: 33826
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonRepresentation_SetState_15(HandleRef pThis, int state);

		/// <summary>
		/// Manipulate the state. Note that the NextState() and PreviousState() methods
		/// use modulo traversal. The "state" integral value will be clamped within
		/// the possible state values (0&lt;=state&lt;NumberOfStates). Note that subclasses
		/// will override these methods in many cases.
		/// </summary>
		// Token: 0x06008423 RID: 33827 RVA: 0x000BCBE3 File Offset: 0x000BADE3
		public virtual void SetState(int state)
		{
			vtkButtonRepresentation.vtkButtonRepresentation_SetState_15(base.GetCppThis(), state);
		}

		// Token: 0x06008424 RID: 33828
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkButtonRepresentation_ShallowCopy_16(HandleRef pThis, HandleRef prop);

		/// <summary>
		/// Satisfy some of vtkProp's API.
		/// </summary>
		// Token: 0x06008425 RID: 33829 RVA: 0x000BCBF4 File Offset: 0x000BADF4
		public override void ShallowCopy(vtkProp prop)
		{
			vtkButtonRepresentation.vtkButtonRepresentation_ShallowCopy_16(base.GetCppThis(), (prop == null) ? default(HandleRef) : prop.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B29 RID: 2857
		public new const string MRFullTypeName = "Kitware.VTK.vtkButtonRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B2A RID: 2858
		public new static readonly string MRClassNameKey = "class vtkButtonRepresentation";

		/// <summary>
		/// These methods control the appearance of the button as it is being
		/// interacted with. Subclasses will behave differently depending on their
		/// particulars.  HighlightHovering is used when the mouse pointer moves
		/// over the button. HighlightSelecting is set when the button is selected.
		/// Otherwise, the HighlightNormal is used. The Highlight() method will throw
		/// a vtkCommand::HighlightEvent.
		/// </summary>
		// Token: 0x020002DC RID: 732
		public enum HighlightStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000B2C RID: 2860
			HighlightHovering = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000B2D RID: 2861
			HighlightNormal = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000B2E RID: 2862
			HighlightSelecting = 2
		}

		/// <summary>
		/// Manipulate the state. Note that the NextState() and PreviousState() methods
		/// use modulo traversal. The "state" integral value will be clamped within
		/// the possible state values (0&lt;=state&lt;NumberOfStates). Note that subclasses
		/// will override these methods in many cases.
		/// </summary>
		// Token: 0x020002DD RID: 733
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000B30 RID: 2864
			Inside = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000B31 RID: 2865
			Outside = 0
		}
	}
}

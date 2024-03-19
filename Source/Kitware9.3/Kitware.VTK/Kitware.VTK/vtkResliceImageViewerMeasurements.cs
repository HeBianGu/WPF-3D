using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkResliceImageViewerMeasurements
	/// </summary>
	/// <remarks>
	///    Manage measurements on a resliced image
	///
	/// This class manages measurements on the resliced image. It toggles the
	/// the visibility of the measurements based on whether the resliced image
	/// is the same orientation as when the measurement was initially placed.
	/// </remarks>
	/// <seealso>
	///
	/// vtkResliceCursor vtkResliceCursorWidget vtkResliceCursorRepresentation
	/// </seealso>
	// Token: 0x02000233 RID: 563
	public class vtkResliceImageViewerMeasurements : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600693F RID: 26943 RVA: 0x000981C3 File Offset: 0x000963C3
		static vtkResliceImageViewerMeasurements()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkResliceImageViewerMeasurements.MRClassNameKey, Type.GetType("Kitware.VTK.vtkResliceImageViewerMeasurements"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006940 RID: 26944 RVA: 0x000981EB File Offset: 0x000963EB
		public vtkResliceImageViewerMeasurements(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006941 RID: 26945
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceImageViewerMeasurements_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06006942 RID: 26946 RVA: 0x000981FC File Offset: 0x000963FC
		public new static vtkResliceImageViewerMeasurements New()
		{
			vtkResliceImageViewerMeasurements result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceImageViewerMeasurements)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06006943 RID: 26947 RVA: 0x00098250 File Offset: 0x00096450
		public vtkResliceImageViewerMeasurements() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006944 RID: 26948 RVA: 0x00098294 File Offset: 0x00096494
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006945 RID: 26949
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewerMeasurements_AddItem_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add / remove a measurement widget
		/// </summary>
		// Token: 0x06006946 RID: 26950 RVA: 0x000982A0 File Offset: 0x000964A0
		public virtual void AddItem(vtkAbstractWidget arg0)
		{
			vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_AddItem_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06006947 RID: 26951
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceImageViewerMeasurements_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06006948 RID: 26952 RVA: 0x000982D0 File Offset: 0x000964D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06006949 RID: 26953
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkResliceImageViewerMeasurements_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600694A RID: 26954 RVA: 0x000982F0 File Offset: 0x000964F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600694B RID: 26955
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceImageViewerMeasurements_GetProcessEvents_04(HandleRef pThis);

		/// <summary>
		/// Methods to change whether the widget responds to interaction.
		/// Set this to Off to disable interaction. On by default.
		/// Subclasses must override SetProcessEvents() to make sure
		/// that they pass on the flag to all component widgets.
		/// </summary>
		// Token: 0x0600694C RID: 26956 RVA: 0x0009830C File Offset: 0x0009650C
		public virtual int GetProcessEvents()
		{
			return vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_GetProcessEvents_04(base.GetCppThis());
		}

		// Token: 0x0600694D RID: 26957
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceImageViewerMeasurements_GetProcessEventsMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Methods to change whether the widget responds to interaction.
		/// Set this to Off to disable interaction. On by default.
		/// Subclasses must override SetProcessEvents() to make sure
		/// that they pass on the flag to all component widgets.
		/// </summary>
		// Token: 0x0600694E RID: 26958 RVA: 0x0009832C File Offset: 0x0009652C
		public virtual int GetProcessEventsMaxValue()
		{
			return vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_GetProcessEventsMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600694F RID: 26959
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceImageViewerMeasurements_GetProcessEventsMinValue_06(HandleRef pThis);

		/// <summary>
		/// Methods to change whether the widget responds to interaction.
		/// Set this to Off to disable interaction. On by default.
		/// Subclasses must override SetProcessEvents() to make sure
		/// that they pass on the flag to all component widgets.
		/// </summary>
		// Token: 0x06006950 RID: 26960 RVA: 0x0009834C File Offset: 0x0009654C
		public virtual int GetProcessEventsMinValue()
		{
			return vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_GetProcessEventsMinValue_06(base.GetCppThis());
		}

		// Token: 0x06006951 RID: 26961
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceImageViewerMeasurements_GetResliceImageViewer_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the reslice image viewer. This is automatically done in the class
		/// vtkResliceImageViewer
		/// </summary>
		// Token: 0x06006952 RID: 26962 RVA: 0x0009836C File Offset: 0x0009656C
		public virtual vtkResliceImageViewer GetResliceImageViewer()
		{
			vtkResliceImageViewer vtkResliceImageViewer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_GetResliceImageViewer_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceImageViewer = (vtkResliceImageViewer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceImageViewer.Register(null);
				}
			}
			return vtkResliceImageViewer;
		}

		// Token: 0x06006953 RID: 26963
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkResliceImageViewerMeasurements_GetTolerance_08(HandleRef pThis);

		/// <summary>
		/// Tolerance for Point-in-Plane check
		/// </summary>
		// Token: 0x06006954 RID: 26964 RVA: 0x000983DC File Offset: 0x000965DC
		public virtual double GetTolerance()
		{
			return vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_GetTolerance_08(base.GetCppThis());
		}

		// Token: 0x06006955 RID: 26965
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceImageViewerMeasurements_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06006956 RID: 26966 RVA: 0x000983FC File Offset: 0x000965FC
		public override int IsA(string type)
		{
			return vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06006957 RID: 26967
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkResliceImageViewerMeasurements_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06006958 RID: 26968 RVA: 0x0009841C File Offset: 0x0009661C
		public new static int IsTypeOf(string type)
		{
			return vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_IsTypeOf_10(type);
		}

		// Token: 0x06006959 RID: 26969
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceImageViewerMeasurements_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x0600695A RID: 26970 RVA: 0x00098438 File Offset: 0x00096638
		public new vtkResliceImageViewerMeasurements NewInstance()
		{
			vtkResliceImageViewerMeasurements result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkResliceImageViewerMeasurements)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600695B RID: 26971
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewerMeasurements_ProcessEventsOff_13(HandleRef pThis);

		/// <summary>
		/// Methods to change whether the widget responds to interaction.
		/// Set this to Off to disable interaction. On by default.
		/// Subclasses must override SetProcessEvents() to make sure
		/// that they pass on the flag to all component widgets.
		/// </summary>
		// Token: 0x0600695C RID: 26972 RVA: 0x00098492 File Offset: 0x00096692
		public virtual void ProcessEventsOff()
		{
			vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_ProcessEventsOff_13(base.GetCppThis());
		}

		// Token: 0x0600695D RID: 26973
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewerMeasurements_ProcessEventsOn_14(HandleRef pThis);

		/// <summary>
		/// Methods to change whether the widget responds to interaction.
		/// Set this to Off to disable interaction. On by default.
		/// Subclasses must override SetProcessEvents() to make sure
		/// that they pass on the flag to all component widgets.
		/// </summary>
		// Token: 0x0600695E RID: 26974 RVA: 0x000984A1 File Offset: 0x000966A1
		public virtual void ProcessEventsOn()
		{
			vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_ProcessEventsOn_14(base.GetCppThis());
		}

		// Token: 0x0600695F RID: 26975
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewerMeasurements_RemoveAllItems_15(HandleRef pThis);

		/// <summary>
		/// Add / remove a measurement widget
		/// </summary>
		// Token: 0x06006960 RID: 26976 RVA: 0x000984B0 File Offset: 0x000966B0
		public virtual void RemoveAllItems()
		{
			vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_RemoveAllItems_15(base.GetCppThis());
		}

		// Token: 0x06006961 RID: 26977
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewerMeasurements_RemoveItem_16(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add / remove a measurement widget
		/// </summary>
		// Token: 0x06006962 RID: 26978 RVA: 0x000984C0 File Offset: 0x000966C0
		public virtual void RemoveItem(vtkAbstractWidget arg0)
		{
			vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_RemoveItem_16(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06006963 RID: 26979
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewerMeasurements_Render_17(HandleRef pThis);

		/// <summary>
		/// Render the measurements.
		/// </summary>
		// Token: 0x06006964 RID: 26980 RVA: 0x000984EF File Offset: 0x000966EF
		public virtual void Render()
		{
			vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_Render_17(base.GetCppThis());
		}

		// Token: 0x06006965 RID: 26981
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkResliceImageViewerMeasurements_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06006966 RID: 26982 RVA: 0x00098500 File Offset: 0x00096700
		public new static vtkResliceImageViewerMeasurements SafeDownCast(vtkObjectBase o)
		{
			vtkResliceImageViewerMeasurements vtkResliceImageViewerMeasurements = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkResliceImageViewerMeasurements = (vtkResliceImageViewerMeasurements)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkResliceImageViewerMeasurements.Register(null);
				}
			}
			return vtkResliceImageViewerMeasurements;
		}

		// Token: 0x06006967 RID: 26983
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewerMeasurements_SetProcessEvents_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Methods to change whether the widget responds to interaction.
		/// Set this to Off to disable interaction. On by default.
		/// Subclasses must override SetProcessEvents() to make sure
		/// that they pass on the flag to all component widgets.
		/// </summary>
		// Token: 0x06006968 RID: 26984 RVA: 0x0009857F File Offset: 0x0009677F
		public virtual void SetProcessEvents(int _arg)
		{
			vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_SetProcessEvents_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06006969 RID: 26985
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewerMeasurements_SetResliceImageViewer_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the reslice image viewer. This is automatically done in the class
		/// vtkResliceImageViewer
		/// </summary>
		// Token: 0x0600696A RID: 26986 RVA: 0x00098590 File Offset: 0x00096790
		public virtual void SetResliceImageViewer(vtkResliceImageViewer arg0)
		{
			vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_SetResliceImageViewer_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600696B RID: 26987
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewerMeasurements_SetTolerance_21(HandleRef pThis, double _arg);

		/// <summary>
		/// Tolerance for Point-in-Plane check
		/// </summary>
		// Token: 0x0600696C RID: 26988 RVA: 0x000985BF File Offset: 0x000967BF
		public virtual void SetTolerance(double _arg)
		{
			vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_SetTolerance_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600696D RID: 26989
		[DllImport("Kitware.VTK.InteractionImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkResliceImageViewerMeasurements_Update_22(HandleRef pThis);

		/// <summary>
		/// Update the measurements. This is automatically called when the reslice
		/// cursor's axes are change.
		/// </summary>
		// Token: 0x0600696E RID: 26990 RVA: 0x000985CF File Offset: 0x000967CF
		public virtual void Update()
		{
			vtkResliceImageViewerMeasurements.vtkResliceImageViewerMeasurements_Update_22(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000950 RID: 2384
		public new const string MRFullTypeName = "Kitware.VTK.vtkResliceImageViewerMeasurements";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000951 RID: 2385
		public new static readonly string MRClassNameKey = "class vtkResliceImageViewerMeasurements";
	}
}

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageOrthoPlanes
	/// </summary>
	/// <remarks>
	///    Connect three vtkImagePlaneWidgets together
	///
	/// vtkImageOrthoPlanes is an event observer class that listens to the
	/// events from three vtkImagePlaneWidgets and keeps their orientations
	/// and scales synchronized.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImagePlaneWidget
	/// @par Thanks:
	/// Thanks to Atamai Inc. for developing and contributing this class.
	/// </seealso>
	// Token: 0x02000324 RID: 804
	public class vtkImageOrthoPlanes : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008FD4 RID: 36820 RVA: 0x000CCCCD File Offset: 0x000CAECD
		static vtkImageOrthoPlanes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageOrthoPlanes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageOrthoPlanes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008FD5 RID: 36821 RVA: 0x000CCCF5 File Offset: 0x000CAEF5
		public vtkImageOrthoPlanes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008FD6 RID: 36822
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageOrthoPlanes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008FD7 RID: 36823 RVA: 0x000CCD04 File Offset: 0x000CAF04
		public new static vtkImageOrthoPlanes New()
		{
			vtkImageOrthoPlanes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageOrthoPlanes.vtkImageOrthoPlanes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageOrthoPlanes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008FD8 RID: 36824 RVA: 0x000CCD58 File Offset: 0x000CAF58
		public vtkImageOrthoPlanes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageOrthoPlanes.vtkImageOrthoPlanes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008FD9 RID: 36825 RVA: 0x000CCD9C File Offset: 0x000CAF9C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008FDA RID: 36826
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageOrthoPlanes_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008FDB RID: 36827 RVA: 0x000CCDA8 File Offset: 0x000CAFA8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageOrthoPlanes.vtkImageOrthoPlanes_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06008FDC RID: 36828
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageOrthoPlanes_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008FDD RID: 36829 RVA: 0x000CCDC8 File Offset: 0x000CAFC8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageOrthoPlanes.vtkImageOrthoPlanes_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06008FDE RID: 36830
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageOrthoPlanes_GetPlane_03(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// You must set three planes for the widget.
		/// </summary>
		// Token: 0x06008FDF RID: 36831 RVA: 0x000CCDE4 File Offset: 0x000CAFE4
		public vtkImagePlaneWidget GetPlane(int i)
		{
			vtkImagePlaneWidget vtkImagePlaneWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageOrthoPlanes.vtkImageOrthoPlanes_GetPlane_03(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImagePlaneWidget = (vtkImagePlaneWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImagePlaneWidget.Register(null);
				}
			}
			return vtkImagePlaneWidget;
		}

		// Token: 0x06008FE0 RID: 36832
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageOrthoPlanes_GetTransform_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the transform for the planes.
		/// </summary>
		// Token: 0x06008FE1 RID: 36833 RVA: 0x000CCE54 File Offset: 0x000CB054
		public vtkTransform GetTransform()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageOrthoPlanes.vtkImageOrthoPlanes_GetTransform_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		// Token: 0x06008FE2 RID: 36834
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageOrthoPlanes_HandlePlaneEvent_05(HandleRef pThis, HandleRef imagePlaneWidget);

		/// <summary>
		/// A public method to be used only by the event callback.
		/// </summary>
		// Token: 0x06008FE3 RID: 36835 RVA: 0x000CCEC4 File Offset: 0x000CB0C4
		public void HandlePlaneEvent(vtkImagePlaneWidget imagePlaneWidget)
		{
			vtkImageOrthoPlanes.vtkImageOrthoPlanes_HandlePlaneEvent_05(base.GetCppThis(), (imagePlaneWidget == null) ? default(HandleRef) : imagePlaneWidget.GetCppThis());
		}

		// Token: 0x06008FE4 RID: 36836
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageOrthoPlanes_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008FE5 RID: 36837 RVA: 0x000CCEF4 File Offset: 0x000CB0F4
		public override int IsA(string type)
		{
			return vtkImageOrthoPlanes.vtkImageOrthoPlanes_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06008FE6 RID: 36838
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageOrthoPlanes_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008FE7 RID: 36839 RVA: 0x000CCF14 File Offset: 0x000CB114
		public new static int IsTypeOf(string type)
		{
			return vtkImageOrthoPlanes.vtkImageOrthoPlanes_IsTypeOf_07(type);
		}

		// Token: 0x06008FE8 RID: 36840
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageOrthoPlanes_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008FE9 RID: 36841 RVA: 0x000CCF30 File Offset: 0x000CB130
		public new vtkImageOrthoPlanes NewInstance()
		{
			vtkImageOrthoPlanes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageOrthoPlanes.vtkImageOrthoPlanes_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageOrthoPlanes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008FEA RID: 36842
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageOrthoPlanes_ResetPlanes_10(HandleRef pThis);

		/// <summary>
		/// Reset the planes to original scale, rotation, and location.
		/// </summary>
		// Token: 0x06008FEB RID: 36843 RVA: 0x000CCF8A File Offset: 0x000CB18A
		public void ResetPlanes()
		{
			vtkImageOrthoPlanes.vtkImageOrthoPlanes_ResetPlanes_10(base.GetCppThis());
		}

		// Token: 0x06008FEC RID: 36844
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageOrthoPlanes_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06008FED RID: 36845 RVA: 0x000CCF9C File Offset: 0x000CB19C
		public new static vtkImageOrthoPlanes SafeDownCast(vtkObjectBase o)
		{
			vtkImageOrthoPlanes vtkImageOrthoPlanes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageOrthoPlanes.vtkImageOrthoPlanes_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageOrthoPlanes = (vtkImageOrthoPlanes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageOrthoPlanes.Register(null);
				}
			}
			return vtkImageOrthoPlanes;
		}

		// Token: 0x06008FEE RID: 36846
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageOrthoPlanes_SetPlane_12(HandleRef pThis, int i, HandleRef imagePlaneWidget);

		/// <summary>
		/// You must set three planes for the widget.
		/// </summary>
		// Token: 0x06008FEF RID: 36847 RVA: 0x000CD01C File Offset: 0x000CB21C
		public void SetPlane(int i, vtkImagePlaneWidget imagePlaneWidget)
		{
			vtkImageOrthoPlanes.vtkImageOrthoPlanes_SetPlane_12(base.GetCppThis(), i, (imagePlaneWidget == null) ? default(HandleRef) : imagePlaneWidget.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C06 RID: 3078
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageOrthoPlanes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000C07 RID: 3079
		public new static readonly string MRClassNameKey = "class vtkImageOrthoPlanes";
	}
}

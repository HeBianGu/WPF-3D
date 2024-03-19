using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCameraWidget
	/// </summary>
	/// <remarks>
	///    2D widget for saving a series of camera views
	///
	/// This class provides support for interactively saving a series of camera
	/// views into an interpolated path (using vtkCameraInterpolator). To use the
	/// class start by specifying a camera to interpolate, and then simply start
	/// recording by hitting the "record" button, manipulate the camera (by using
	/// an interactor, direct scripting, or any other means), and then save the
	/// camera view. Repeat this process to record a series of views.  The user
	/// can then play back interpolated camera views using the
	/// vtkCameraInterpolator.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBorderWidget vtkCameraInterpolator
	/// </seealso>
	// Token: 0x020002EB RID: 747
	public class vtkCameraWidget : vtkBorderWidget
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008647 RID: 34375 RVA: 0x000BFA8B File Offset: 0x000BDC8B
		static vtkCameraWidget()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCameraWidget.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCameraWidget"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008648 RID: 34376 RVA: 0x000BFAB3 File Offset: 0x000BDCB3
		public vtkCameraWidget(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008649 RID: 34377
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraWidget_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600864A RID: 34378 RVA: 0x000BFAC4 File Offset: 0x000BDCC4
		public new static vtkCameraWidget New()
		{
			vtkCameraWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraWidget.vtkCameraWidget_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate this class.
		/// </summary>
		// Token: 0x0600864B RID: 34379 RVA: 0x000BFB18 File Offset: 0x000BDD18
		public vtkCameraWidget() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCameraWidget.vtkCameraWidget_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600864C RID: 34380 RVA: 0x000BFB5C File Offset: 0x000BDD5C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600864D RID: 34381
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraWidget_CreateDefaultRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Create the default widget representation if one is not set.
		/// </summary>
		// Token: 0x0600864E RID: 34382 RVA: 0x000BFB67 File Offset: 0x000BDD67
		public override void CreateDefaultRepresentation()
		{
			vtkCameraWidget.vtkCameraWidget_CreateDefaultRepresentation_01(base.GetCppThis());
		}

		// Token: 0x0600864F RID: 34383
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraWidget_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06008650 RID: 34384 RVA: 0x000BFB78 File Offset: 0x000BDD78
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCameraWidget.vtkCameraWidget_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06008651 RID: 34385
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCameraWidget_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06008652 RID: 34386 RVA: 0x000BFB98 File Offset: 0x000BDD98
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCameraWidget.vtkCameraWidget_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06008653 RID: 34387
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraWidget_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06008654 RID: 34388 RVA: 0x000BFBB4 File Offset: 0x000BDDB4
		public override int IsA(string type)
		{
			return vtkCameraWidget.vtkCameraWidget_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06008655 RID: 34389
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCameraWidget_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06008656 RID: 34390 RVA: 0x000BFBD4 File Offset: 0x000BDDD4
		public new static int IsTypeOf(string type)
		{
			return vtkCameraWidget.vtkCameraWidget_IsTypeOf_05(type);
		}

		// Token: 0x06008657 RID: 34391
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraWidget_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x06008658 RID: 34392 RVA: 0x000BFBF0 File Offset: 0x000BDDF0
		public new vtkCameraWidget NewInstance()
		{
			vtkCameraWidget result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraWidget.vtkCameraWidget_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCameraWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008659 RID: 34393
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCameraWidget_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK class methods.
		/// </summary>
		// Token: 0x0600865A RID: 34394 RVA: 0x000BFC4C File Offset: 0x000BDE4C
		public new static vtkCameraWidget SafeDownCast(vtkObjectBase o)
		{
			vtkCameraWidget vtkCameraWidget = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCameraWidget.vtkCameraWidget_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCameraWidget = (vtkCameraWidget)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCameraWidget.Register(null);
				}
			}
			return vtkCameraWidget;
		}

		// Token: 0x0600865B RID: 34395
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCameraWidget_SetRepresentation_09(HandleRef pThis, HandleRef r);

		/// <summary>
		/// Specify an instance of vtkWidgetRepresentation used to represent this
		/// widget in the scene. Note that the representation is a subclass of vtkProp
		/// so it can be added to the renderer independent of the widget.
		/// </summary>
		// Token: 0x0600865C RID: 34396 RVA: 0x000BFCCC File Offset: 0x000BDECC
		public void SetRepresentation(vtkCameraRepresentation r)
		{
			vtkCameraWidget.vtkCameraWidget_SetRepresentation_09(base.GetCppThis(), (r == null) ? default(HandleRef) : r.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B57 RID: 2903
		public new const string MRFullTypeName = "Kitware.VTK.vtkCameraWidget";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000B58 RID: 2904
		public new static readonly string MRClassNameKey = "class vtkCameraWidget";
	}
}

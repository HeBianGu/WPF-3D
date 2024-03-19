using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkObserverMediator
	/// </summary>
	/// <remarks>
	///    manage contention for cursors and other resources
	///
	/// The vtkObserverMediator is a helper class that manages requests for
	/// cursor changes from multiple interactor observers (e.g. widgets). It keeps
	/// a list of widgets (and their priorities) and their current requests for
	/// cursor shape. It then satisfies requests based on widget priority and the
	/// relative importance of the request (e.g., a lower priority widget
	/// requesting a particular cursor shape will overrule a higher priority
	/// widget requesting a default shape).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkAbstractWidget vtkWidgetRepresentation
	/// </seealso>
	// Token: 0x020007F6 RID: 2038
	public class vtkObserverMediator : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014F06 RID: 85766 RVA: 0x001D9E5B File Offset: 0x001D805B
		static vtkObserverMediator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkObserverMediator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkObserverMediator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014F07 RID: 85767 RVA: 0x001D9E83 File Offset: 0x001D8083
		public vtkObserverMediator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014F08 RID: 85768
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObserverMediator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06014F09 RID: 85769 RVA: 0x001D9E94 File Offset: 0x001D8094
		public new static vtkObserverMediator New()
		{
			vtkObserverMediator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObserverMediator.vtkObserverMediator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObserverMediator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06014F0A RID: 85770 RVA: 0x001D9EE8 File Offset: 0x001D80E8
		public vtkObserverMediator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkObserverMediator.vtkObserverMediator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014F0B RID: 85771 RVA: 0x001D9F2C File Offset: 0x001D812C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014F0C RID: 85772
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObserverMediator_GetInteractor_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the instance of vtkRenderWindow whose cursor shape is
		/// to be managed.
		/// </summary>
		// Token: 0x06014F0D RID: 85773 RVA: 0x001D9F38 File Offset: 0x001D8138
		public virtual vtkRenderWindowInteractor GetInteractor()
		{
			vtkRenderWindowInteractor vtkRenderWindowInteractor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObserverMediator.vtkObserverMediator_GetInteractor_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRenderWindowInteractor = (vtkRenderWindowInteractor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRenderWindowInteractor.Register(null);
				}
			}
			return vtkRenderWindowInteractor;
		}

		// Token: 0x06014F0E RID: 85774
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkObserverMediator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06014F0F RID: 85775 RVA: 0x001D9FA8 File Offset: 0x001D81A8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkObserverMediator.vtkObserverMediator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06014F10 RID: 85776
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkObserverMediator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06014F11 RID: 85777 RVA: 0x001D9FC8 File Offset: 0x001D81C8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkObserverMediator.vtkObserverMediator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06014F12 RID: 85778
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObserverMediator_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06014F13 RID: 85779 RVA: 0x001D9FE4 File Offset: 0x001D81E4
		public override int IsA(string type)
		{
			return vtkObserverMediator.vtkObserverMediator_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06014F14 RID: 85780
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObserverMediator_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06014F15 RID: 85781 RVA: 0x001DA004 File Offset: 0x001D8204
		public new static int IsTypeOf(string type)
		{
			return vtkObserverMediator.vtkObserverMediator_IsTypeOf_05(type);
		}

		// Token: 0x06014F16 RID: 85782
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObserverMediator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06014F17 RID: 85783 RVA: 0x001DA020 File Offset: 0x001D8220
		public new vtkObserverMediator NewInstance()
		{
			vtkObserverMediator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObserverMediator.vtkObserverMediator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkObserverMediator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014F18 RID: 85784
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObserverMediator_RemoveAllCursorShapeRequests_08(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Remove all requests for cursor shape from a given interactor.
		/// </summary>
		// Token: 0x06014F19 RID: 85785 RVA: 0x001DA07C File Offset: 0x001D827C
		public void RemoveAllCursorShapeRequests(vtkInteractorObserver arg0)
		{
			vtkObserverMediator.vtkObserverMediator_RemoveAllCursorShapeRequests_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06014F1A RID: 85786
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkObserverMediator_RequestCursorShape_09(HandleRef pThis, HandleRef arg0, int requestedShape);

		/// <summary>
		/// Method used to request a cursor shape. Note that the shape is specified
		/// using one of the integral values determined in vtkRenderWindow.h. The
		/// method returns a non-zero value if the shape was successfully changed.
		/// </summary>
		// Token: 0x06014F1B RID: 85787 RVA: 0x001DA0AC File Offset: 0x001D82AC
		public int RequestCursorShape(vtkInteractorObserver arg0, int requestedShape)
		{
			return vtkObserverMediator.vtkObserverMediator_RequestCursorShape_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis(), requestedShape);
		}

		// Token: 0x06014F1C RID: 85788
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkObserverMediator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard macros.
		/// </summary>
		// Token: 0x06014F1D RID: 85789 RVA: 0x001DA0E4 File Offset: 0x001D82E4
		public new static vtkObserverMediator SafeDownCast(vtkObjectBase o)
		{
			vtkObserverMediator vtkObserverMediator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkObserverMediator.vtkObserverMediator_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObserverMediator = (vtkObserverMediator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObserverMediator.Register(null);
				}
			}
			return vtkObserverMediator;
		}

		// Token: 0x06014F1E RID: 85790
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkObserverMediator_SetInteractor_11(HandleRef pThis, HandleRef iren);

		/// <summary>
		/// Specify the instance of vtkRenderWindow whose cursor shape is
		/// to be managed.
		/// </summary>
		// Token: 0x06014F1F RID: 85791 RVA: 0x001DA164 File Offset: 0x001D8364
		public void SetInteractor(vtkRenderWindowInteractor iren)
		{
			vtkObserverMediator.vtkObserverMediator_SetInteractor_11(base.GetCppThis(), (iren == null) ? default(HandleRef) : iren.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001830 RID: 6192
		public new const string MRFullTypeName = "Kitware.VTK.vtkObserverMediator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001831 RID: 6193
		public new static readonly string MRClassNameKey = "class vtkObserverMediator";
	}
}

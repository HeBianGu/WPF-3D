using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkOpenGLCompositePolyDataMapperDelegator
	/// </summary>
	/// <remarks>
	///  An OpenGL delegator for batched rendering of multiple polydata with similar structure.
	///
	/// This class delegates work to vtkOpenGLBatchedPolyDataMapper which can do batched rendering
	/// of many polydata.
	///
	/// </remarks>
	/// <seealso>
	///  vtkOpenGLBatchedPolyDataMapper
	/// </seealso>
	// Token: 0x02000107 RID: 263
	public class vtkOpenGLCompositePolyDataMapperDelegator : vtkCompositePolyDataMapperDelegator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600361C RID: 13852 RVA: 0x0004EEC1 File Offset: 0x0004D0C1
		static vtkOpenGLCompositePolyDataMapperDelegator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLCompositePolyDataMapperDelegator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLCompositePolyDataMapperDelegator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600361D RID: 13853 RVA: 0x0004EEE9 File Offset: 0x0004D0E9
		public vtkOpenGLCompositePolyDataMapperDelegator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600361E RID: 13854
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLCompositePolyDataMapperDelegator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600361F RID: 13855 RVA: 0x0004EEF8 File Offset: 0x0004D0F8
		public new static vtkOpenGLCompositePolyDataMapperDelegator New()
		{
			vtkOpenGLCompositePolyDataMapperDelegator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLCompositePolyDataMapperDelegator.vtkOpenGLCompositePolyDataMapperDelegator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLCompositePolyDataMapperDelegator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003620 RID: 13856 RVA: 0x0004EF4C File Offset: 0x0004D14C
		public vtkOpenGLCompositePolyDataMapperDelegator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLCompositePolyDataMapperDelegator.vtkOpenGLCompositePolyDataMapperDelegator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003621 RID: 13857 RVA: 0x0004EF90 File Offset: 0x0004D190
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003622 RID: 13858
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLCompositePolyDataMapperDelegator_ClearUnmarkedBatchElements_01(HandleRef pThis);

		/// <summary>
		/// Implement parent class API.
		/// </summary>
		// Token: 0x06003623 RID: 13859 RVA: 0x0004EF9B File Offset: 0x0004D19B
		public override void ClearUnmarkedBatchElements()
		{
			vtkOpenGLCompositePolyDataMapperDelegator.vtkOpenGLCompositePolyDataMapperDelegator_ClearUnmarkedBatchElements_01(base.GetCppThis());
		}

		// Token: 0x06003624 RID: 13860
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLCompositePolyDataMapperDelegator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003625 RID: 13861 RVA: 0x0004EFAC File Offset: 0x0004D1AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLCompositePolyDataMapperDelegator.vtkOpenGLCompositePolyDataMapperDelegator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06003626 RID: 13862
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLCompositePolyDataMapperDelegator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003627 RID: 13863 RVA: 0x0004EFCC File Offset: 0x0004D1CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLCompositePolyDataMapperDelegator.vtkOpenGLCompositePolyDataMapperDelegator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06003628 RID: 13864
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLCompositePolyDataMapperDelegator_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003629 RID: 13865 RVA: 0x0004EFE8 File Offset: 0x0004D1E8
		public override int IsA(string type)
		{
			return vtkOpenGLCompositePolyDataMapperDelegator.vtkOpenGLCompositePolyDataMapperDelegator_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600362A RID: 13866
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLCompositePolyDataMapperDelegator_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600362B RID: 13867 RVA: 0x0004F008 File Offset: 0x0004D208
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLCompositePolyDataMapperDelegator.vtkOpenGLCompositePolyDataMapperDelegator_IsTypeOf_05(type);
		}

		// Token: 0x0600362C RID: 13868
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLCompositePolyDataMapperDelegator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600362D RID: 13869 RVA: 0x0004F024 File Offset: 0x0004D224
		public new vtkOpenGLCompositePolyDataMapperDelegator NewInstance()
		{
			vtkOpenGLCompositePolyDataMapperDelegator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLCompositePolyDataMapperDelegator.vtkOpenGLCompositePolyDataMapperDelegator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLCompositePolyDataMapperDelegator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600362E RID: 13870
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLCompositePolyDataMapperDelegator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600362F RID: 13871 RVA: 0x0004F080 File Offset: 0x0004D280
		public new static vtkOpenGLCompositePolyDataMapperDelegator SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLCompositePolyDataMapperDelegator vtkOpenGLCompositePolyDataMapperDelegator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLCompositePolyDataMapperDelegator.vtkOpenGLCompositePolyDataMapperDelegator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLCompositePolyDataMapperDelegator = (vtkOpenGLCompositePolyDataMapperDelegator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLCompositePolyDataMapperDelegator.Register(null);
				}
			}
			return vtkOpenGLCompositePolyDataMapperDelegator;
		}

		// Token: 0x06003630 RID: 13872
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLCompositePolyDataMapperDelegator_ShallowCopy_09(HandleRef pThis, HandleRef mapper);

		/// <summary>
		/// Implement parent class API.
		/// </summary>
		// Token: 0x06003631 RID: 13873 RVA: 0x0004F100 File Offset: 0x0004D300
		public override void ShallowCopy(vtkCompositePolyDataMapper mapper)
		{
			vtkOpenGLCompositePolyDataMapperDelegator.vtkOpenGLCompositePolyDataMapperDelegator_ShallowCopy_09(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x06003632 RID: 13874
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLCompositePolyDataMapperDelegator_UnmarkBatchElements_10(HandleRef pThis);

		/// <summary>
		/// Implement parent class API.
		/// </summary>
		// Token: 0x06003633 RID: 13875 RVA: 0x0004F12F File Offset: 0x0004D32F
		public override void UnmarkBatchElements()
		{
			vtkOpenGLCompositePolyDataMapperDelegator.vtkOpenGLCompositePolyDataMapperDelegator_UnmarkBatchElements_10(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000646 RID: 1606
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLCompositePolyDataMapperDelegator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000647 RID: 1607
		public new static readonly string MRClassNameKey = "class vtkOpenGLCompositePolyDataMapperDelegator";
	}
}

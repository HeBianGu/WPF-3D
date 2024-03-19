using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeSurfaceLICMapperDelegator
	/// </summary>
	/// <remarks>
	///    Delegates rendering to vtkBatchedSurfaceLICMapper.
	///
	/// </remarks>
	/// <seealso>
	///  vtkBatchedSurfaceLICMapper
	/// </seealso>
	// Token: 0x02000108 RID: 264
	public class vtkCompositeSurfaceLICMapperDelegator : vtkOpenGLCompositePolyDataMapperDelegator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003634 RID: 13876 RVA: 0x0004F13E File Offset: 0x0004D33E
		static vtkCompositeSurfaceLICMapperDelegator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeSurfaceLICMapperDelegator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeSurfaceLICMapperDelegator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003635 RID: 13877 RVA: 0x0004F166 File Offset: 0x0004D366
		public vtkCompositeSurfaceLICMapperDelegator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003636 RID: 13878
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeSurfaceLICMapperDelegator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003637 RID: 13879 RVA: 0x0004F174 File Offset: 0x0004D374
		public new static vtkCompositeSurfaceLICMapperDelegator New()
		{
			vtkCompositeSurfaceLICMapperDelegator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeSurfaceLICMapperDelegator.vtkCompositeSurfaceLICMapperDelegator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeSurfaceLICMapperDelegator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003638 RID: 13880 RVA: 0x0004F1C8 File Offset: 0x0004D3C8
		public vtkCompositeSurfaceLICMapperDelegator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositeSurfaceLICMapperDelegator.vtkCompositeSurfaceLICMapperDelegator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003639 RID: 13881 RVA: 0x0004F20C File Offset: 0x0004D40C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600363A RID: 13882
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeSurfaceLICMapperDelegator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600363B RID: 13883 RVA: 0x0004F218 File Offset: 0x0004D418
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeSurfaceLICMapperDelegator.vtkCompositeSurfaceLICMapperDelegator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600363C RID: 13884
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeSurfaceLICMapperDelegator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600363D RID: 13885 RVA: 0x0004F238 File Offset: 0x0004D438
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeSurfaceLICMapperDelegator.vtkCompositeSurfaceLICMapperDelegator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600363E RID: 13886
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeSurfaceLICMapperDelegator_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600363F RID: 13887 RVA: 0x0004F254 File Offset: 0x0004D454
		public override int IsA(string type)
		{
			return vtkCompositeSurfaceLICMapperDelegator.vtkCompositeSurfaceLICMapperDelegator_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06003640 RID: 13888
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeSurfaceLICMapperDelegator_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003641 RID: 13889 RVA: 0x0004F274 File Offset: 0x0004D474
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeSurfaceLICMapperDelegator.vtkCompositeSurfaceLICMapperDelegator_IsTypeOf_04(type);
		}

		// Token: 0x06003642 RID: 13890
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeSurfaceLICMapperDelegator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003643 RID: 13891 RVA: 0x0004F290 File Offset: 0x0004D490
		public new vtkCompositeSurfaceLICMapperDelegator NewInstance()
		{
			vtkCompositeSurfaceLICMapperDelegator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeSurfaceLICMapperDelegator.vtkCompositeSurfaceLICMapperDelegator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeSurfaceLICMapperDelegator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003644 RID: 13892
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeSurfaceLICMapperDelegator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003645 RID: 13893 RVA: 0x0004F2EC File Offset: 0x0004D4EC
		public new static vtkCompositeSurfaceLICMapperDelegator SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeSurfaceLICMapperDelegator vtkCompositeSurfaceLICMapperDelegator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeSurfaceLICMapperDelegator.vtkCompositeSurfaceLICMapperDelegator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeSurfaceLICMapperDelegator = (vtkCompositeSurfaceLICMapperDelegator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeSurfaceLICMapperDelegator.Register(null);
				}
			}
			return vtkCompositeSurfaceLICMapperDelegator;
		}

		// Token: 0x06003646 RID: 13894
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeSurfaceLICMapperDelegator_ShallowCopy_08(HandleRef pThis, HandleRef mapper);

		/// <summary>
		/// Copy over the reference to the input array of vectors
		/// that gets used by BatchedSurfaceLICMapper
		/// </summary>
		// Token: 0x06003647 RID: 13895 RVA: 0x0004F36C File Offset: 0x0004D56C
		public override void ShallowCopy(vtkCompositePolyDataMapper mapper)
		{
			vtkCompositeSurfaceLICMapperDelegator.vtkCompositeSurfaceLICMapperDelegator_ShallowCopy_08(base.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000648 RID: 1608
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeSurfaceLICMapperDelegator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000649 RID: 1609
		public new static readonly string MRClassNameKey = "class vtkCompositeSurfaceLICMapperDelegator";
	}
}

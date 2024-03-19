using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeSurfaceLICMapper
	/// </summary>
	/// <remarks>
	///    mapper for composite dataset
	///
	/// vtkCompositeSurfaceLICMapper is similar to
	/// vtkGenericCompositeSurfaceLICMapper but requires that its inputs all have the
	/// same properties (normals, tcoord, scalars, etc) It will only draw
	/// polys and it does not support edge flags. The advantage to using
	/// this class is that it generally should be faster
	/// </remarks>
	// Token: 0x02000105 RID: 261
	public class vtkCompositeSurfaceLICMapper : vtkCompositePolyDataMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060035E6 RID: 13798 RVA: 0x0004E947 File Offset: 0x0004CB47
		static vtkCompositeSurfaceLICMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeSurfaceLICMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeSurfaceLICMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060035E7 RID: 13799 RVA: 0x0004E96F File Offset: 0x0004CB6F
		public vtkCompositeSurfaceLICMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060035E8 RID: 13800
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeSurfaceLICMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060035E9 RID: 13801 RVA: 0x0004E980 File Offset: 0x0004CB80
		public new static vtkCompositeSurfaceLICMapper New()
		{
			vtkCompositeSurfaceLICMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeSurfaceLICMapper.vtkCompositeSurfaceLICMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeSurfaceLICMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060035EA RID: 13802 RVA: 0x0004E9D4 File Offset: 0x0004CBD4
		public vtkCompositeSurfaceLICMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositeSurfaceLICMapper.vtkCompositeSurfaceLICMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060035EB RID: 13803 RVA: 0x0004EA18 File Offset: 0x0004CC18
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060035EC RID: 13804
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeSurfaceLICMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060035ED RID: 13805 RVA: 0x0004EA24 File Offset: 0x0004CC24
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeSurfaceLICMapper.vtkCompositeSurfaceLICMapper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060035EE RID: 13806
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeSurfaceLICMapper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060035EF RID: 13807 RVA: 0x0004EA44 File Offset: 0x0004CC44
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeSurfaceLICMapper.vtkCompositeSurfaceLICMapper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060035F0 RID: 13808
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeSurfaceLICMapper_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060035F1 RID: 13809 RVA: 0x0004EA60 File Offset: 0x0004CC60
		public override int IsA(string type)
		{
			return vtkCompositeSurfaceLICMapper.vtkCompositeSurfaceLICMapper_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060035F2 RID: 13810
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeSurfaceLICMapper_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060035F3 RID: 13811 RVA: 0x0004EA80 File Offset: 0x0004CC80
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeSurfaceLICMapper.vtkCompositeSurfaceLICMapper_IsTypeOf_04(type);
		}

		// Token: 0x060035F4 RID: 13812
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeSurfaceLICMapper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060035F5 RID: 13813 RVA: 0x0004EA9C File Offset: 0x0004CC9C
		public new vtkCompositeSurfaceLICMapper NewInstance()
		{
			vtkCompositeSurfaceLICMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeSurfaceLICMapper.vtkCompositeSurfaceLICMapper_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeSurfaceLICMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060035F6 RID: 13814
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCompositeSurfaceLICMapper_Render_07(HandleRef pThis, HandleRef ren, HandleRef act);

		/// <summary>
		/// Lots of LIC setup code
		/// </summary>
		// Token: 0x060035F7 RID: 13815 RVA: 0x0004EAF8 File Offset: 0x0004CCF8
		public override void Render(vtkRenderer ren, vtkActor act)
		{
			vtkCompositeSurfaceLICMapper.vtkCompositeSurfaceLICMapper_Render_07(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (act == null) ? default(HandleRef) : act.GetCppThis());
		}

		// Token: 0x060035F8 RID: 13816
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeSurfaceLICMapper_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060035F9 RID: 13817 RVA: 0x0004EB3C File Offset: 0x0004CD3C
		public new static vtkCompositeSurfaceLICMapper SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeSurfaceLICMapper vtkCompositeSurfaceLICMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeSurfaceLICMapper.vtkCompositeSurfaceLICMapper_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeSurfaceLICMapper = (vtkCompositeSurfaceLICMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeSurfaceLICMapper.Register(null);
				}
			}
			return vtkCompositeSurfaceLICMapper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000642 RID: 1602
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeSurfaceLICMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000643 RID: 1603
		public new static readonly string MRClassNameKey = "class vtkCompositeSurfaceLICMapper";
	}
}

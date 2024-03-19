using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBatchedSurfaceLICMapper
	/// </summary>
	/// <remarks>
	///    Implements batched rendering of multiple vtkPolyData using LIC interface and OpenGL.
	///
	/// </remarks>
	/// <seealso>
	///  vtkCompositeSurfaceLICMapperDelegator
	/// </seealso>
	// Token: 0x02000103 RID: 259
	public class vtkBatchedSurfaceLICMapper : vtkOpenGLBatchedPolyDataMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06003542 RID: 13634 RVA: 0x0004DDE2 File Offset: 0x0004BFE2
		static vtkBatchedSurfaceLICMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBatchedSurfaceLICMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBatchedSurfaceLICMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06003543 RID: 13635 RVA: 0x0004DE0A File Offset: 0x0004C00A
		public vtkBatchedSurfaceLICMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06003544 RID: 13636
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBatchedSurfaceLICMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003545 RID: 13637 RVA: 0x0004DE18 File Offset: 0x0004C018
		public new static vtkBatchedSurfaceLICMapper New()
		{
			vtkBatchedSurfaceLICMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBatchedSurfaceLICMapper.vtkBatchedSurfaceLICMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBatchedSurfaceLICMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003546 RID: 13638 RVA: 0x0004DE6C File Offset: 0x0004C06C
		public vtkBatchedSurfaceLICMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBatchedSurfaceLICMapper.vtkBatchedSurfaceLICMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06003547 RID: 13639 RVA: 0x0004DEB0 File Offset: 0x0004C0B0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06003548 RID: 13640
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBatchedSurfaceLICMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003549 RID: 13641 RVA: 0x0004DEBC File Offset: 0x0004C0BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBatchedSurfaceLICMapper.vtkBatchedSurfaceLICMapper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600354A RID: 13642
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBatchedSurfaceLICMapper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600354B RID: 13643 RVA: 0x0004DEDC File Offset: 0x0004C0DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBatchedSurfaceLICMapper.vtkBatchedSurfaceLICMapper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600354C RID: 13644
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBatchedSurfaceLICMapper_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600354D RID: 13645 RVA: 0x0004DEF8 File Offset: 0x0004C0F8
		public override int IsA(string type)
		{
			return vtkBatchedSurfaceLICMapper.vtkBatchedSurfaceLICMapper_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600354E RID: 13646
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBatchedSurfaceLICMapper_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600354F RID: 13647 RVA: 0x0004DF18 File Offset: 0x0004C118
		public new static int IsTypeOf(string type)
		{
			return vtkBatchedSurfaceLICMapper.vtkBatchedSurfaceLICMapper_IsTypeOf_04(type);
		}

		// Token: 0x06003550 RID: 13648
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBatchedSurfaceLICMapper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003551 RID: 13649 RVA: 0x0004DF34 File Offset: 0x0004C134
		public new vtkBatchedSurfaceLICMapper NewInstance()
		{
			vtkBatchedSurfaceLICMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBatchedSurfaceLICMapper.vtkBatchedSurfaceLICMapper_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBatchedSurfaceLICMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06003552 RID: 13650
		[DllImport("Kitware.VTK.RenderingLICOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBatchedSurfaceLICMapper_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06003553 RID: 13651 RVA: 0x0004DF90 File Offset: 0x0004C190
		public new static vtkBatchedSurfaceLICMapper SafeDownCast(vtkObjectBase o)
		{
			vtkBatchedSurfaceLICMapper vtkBatchedSurfaceLICMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBatchedSurfaceLICMapper.vtkBatchedSurfaceLICMapper_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBatchedSurfaceLICMapper = (vtkBatchedSurfaceLICMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBatchedSurfaceLICMapper.Register(null);
				}
			}
			return vtkBatchedSurfaceLICMapper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400063E RID: 1598
		public new const string MRFullTypeName = "Kitware.VTK.vtkBatchedSurfaceLICMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400063F RID: 1599
		public new static readonly string MRClassNameKey = "class vtkBatchedSurfaceLICMapper";
	}
}

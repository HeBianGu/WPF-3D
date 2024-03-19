using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLHyperTreeGridMapper
	/// </summary>
	/// <remarks>
	///    map vtkHyperTreeGrid to graphics primitives
	///
	/// vtkOpenGLHyperTreeGridMapper is a class that uses OpenGL to do the actual
	/// rendering of Hyper Tree Grid.
	/// </remarks>
	// Token: 0x020005B4 RID: 1460
	public class vtkOpenGLHyperTreeGridMapper : vtkHyperTreeGridMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FFCF RID: 65487 RVA: 0x00163F99 File Offset: 0x00162199
		static vtkOpenGLHyperTreeGridMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLHyperTreeGridMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLHyperTreeGridMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FFD0 RID: 65488 RVA: 0x00163FC1 File Offset: 0x001621C1
		public vtkOpenGLHyperTreeGridMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600FFD1 RID: 65489
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLHyperTreeGridMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFD2 RID: 65490 RVA: 0x00163FD0 File Offset: 0x001621D0
		public new static vtkOpenGLHyperTreeGridMapper New()
		{
			vtkOpenGLHyperTreeGridMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLHyperTreeGridMapper.vtkOpenGLHyperTreeGridMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLHyperTreeGridMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFD3 RID: 65491 RVA: 0x00164024 File Offset: 0x00162224
		public vtkOpenGLHyperTreeGridMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLHyperTreeGridMapper.vtkOpenGLHyperTreeGridMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FFD4 RID: 65492 RVA: 0x00164068 File Offset: 0x00162268
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FFD5 RID: 65493
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLHyperTreeGridMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFD6 RID: 65494 RVA: 0x00164074 File Offset: 0x00162274
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLHyperTreeGridMapper.vtkOpenGLHyperTreeGridMapper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600FFD7 RID: 65495
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLHyperTreeGridMapper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFD8 RID: 65496 RVA: 0x00164094 File Offset: 0x00162294
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLHyperTreeGridMapper.vtkOpenGLHyperTreeGridMapper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600FFD9 RID: 65497
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLHyperTreeGridMapper_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFDA RID: 65498 RVA: 0x001640B0 File Offset: 0x001622B0
		public override int IsA(string type)
		{
			return vtkOpenGLHyperTreeGridMapper.vtkOpenGLHyperTreeGridMapper_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600FFDB RID: 65499
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLHyperTreeGridMapper_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFDC RID: 65500 RVA: 0x001640D0 File Offset: 0x001622D0
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLHyperTreeGridMapper.vtkOpenGLHyperTreeGridMapper_IsTypeOf_04(type);
		}

		// Token: 0x0600FFDD RID: 65501
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLHyperTreeGridMapper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFDE RID: 65502 RVA: 0x001640EC File Offset: 0x001622EC
		public new vtkOpenGLHyperTreeGridMapper NewInstance()
		{
			vtkOpenGLHyperTreeGridMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLHyperTreeGridMapper.vtkOpenGLHyperTreeGridMapper_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLHyperTreeGridMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600FFDF RID: 65503
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLHyperTreeGridMapper_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FFE0 RID: 65504 RVA: 0x00164148 File Offset: 0x00162348
		public new static vtkOpenGLHyperTreeGridMapper SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLHyperTreeGridMapper vtkOpenGLHyperTreeGridMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLHyperTreeGridMapper.vtkOpenGLHyperTreeGridMapper_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLHyperTreeGridMapper = (vtkOpenGLHyperTreeGridMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLHyperTreeGridMapper.Register(null);
				}
			}
			return vtkOpenGLHyperTreeGridMapper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012AA RID: 4778
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLHyperTreeGridMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012AB RID: 4779
		public new static readonly string MRClassNameKey = "class vtkOpenGLHyperTreeGridMapper";
	}
}

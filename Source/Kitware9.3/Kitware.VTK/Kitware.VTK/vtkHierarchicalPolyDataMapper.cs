using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHierarchicalPolyDataMapper
	/// </summary>
	/// <remarks>
	///    a class that renders hierarchical polygonal data
	///
	/// Legacy class. Use vtkCompositePolyDataMapper instead.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyDataMapper
	/// </seealso>
	// Token: 0x020007E7 RID: 2023
	public class vtkHierarchicalPolyDataMapper : vtkCompositePolyDataMapper
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06014C96 RID: 85142 RVA: 0x001D6B61 File Offset: 0x001D4D61
		static vtkHierarchicalPolyDataMapper()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalPolyDataMapper.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalPolyDataMapper"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06014C97 RID: 85143 RVA: 0x001D6B89 File Offset: 0x001D4D89
		public vtkHierarchicalPolyDataMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06014C98 RID: 85144
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalPolyDataMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C99 RID: 85145 RVA: 0x001D6B98 File Offset: 0x001D4D98
		public new static vtkHierarchicalPolyDataMapper New()
		{
			vtkHierarchicalPolyDataMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalPolyDataMapper.vtkHierarchicalPolyDataMapper_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalPolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C9A RID: 85146 RVA: 0x001D6BEC File Offset: 0x001D4DEC
		public vtkHierarchicalPolyDataMapper() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHierarchicalPolyDataMapper.vtkHierarchicalPolyDataMapper_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06014C9B RID: 85147 RVA: 0x001D6C30 File Offset: 0x001D4E30
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06014C9C RID: 85148
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalPolyDataMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C9D RID: 85149 RVA: 0x001D6C3C File Offset: 0x001D4E3C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHierarchicalPolyDataMapper.vtkHierarchicalPolyDataMapper_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06014C9E RID: 85150
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalPolyDataMapper_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014C9F RID: 85151 RVA: 0x001D6C5C File Offset: 0x001D4E5C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHierarchicalPolyDataMapper.vtkHierarchicalPolyDataMapper_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06014CA0 RID: 85152
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalPolyDataMapper_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014CA1 RID: 85153 RVA: 0x001D6C78 File Offset: 0x001D4E78
		public override int IsA(string type)
		{
			return vtkHierarchicalPolyDataMapper.vtkHierarchicalPolyDataMapper_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06014CA2 RID: 85154
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalPolyDataMapper_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014CA3 RID: 85155 RVA: 0x001D6C98 File Offset: 0x001D4E98
		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalPolyDataMapper.vtkHierarchicalPolyDataMapper_IsTypeOf_04(type);
		}

		// Token: 0x06014CA4 RID: 85156
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalPolyDataMapper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014CA5 RID: 85157 RVA: 0x001D6CB4 File Offset: 0x001D4EB4
		public new vtkHierarchicalPolyDataMapper NewInstance()
		{
			vtkHierarchicalPolyDataMapper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalPolyDataMapper.vtkHierarchicalPolyDataMapper_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalPolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06014CA6 RID: 85158
		[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalPolyDataMapper_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06014CA7 RID: 85159 RVA: 0x001D6D10 File Offset: 0x001D4F10
		public new static vtkHierarchicalPolyDataMapper SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalPolyDataMapper vtkHierarchicalPolyDataMapper = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalPolyDataMapper.vtkHierarchicalPolyDataMapper_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalPolyDataMapper = (vtkHierarchicalPolyDataMapper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalPolyDataMapper.Register(null);
				}
			}
			return vtkHierarchicalPolyDataMapper;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001803 RID: 6147
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalPolyDataMapper";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001804 RID: 6148
		public new static readonly string MRClassNameKey = "class vtkHierarchicalPolyDataMapper";
	}
}

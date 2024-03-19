using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHierarchicalBoxDataIterator
	/// </summary>
	/// <remarks>
	///    Empty class for backwards compatibility.
	///
	/// @deprecated vtkHierarchicalBoxDataIterator is deprecated in VTK 9.2 and will be removed.
	/// Use `vtkUniformGridAMRDataIterator` instead of `vtkHierarchicalBoxDataIterator`.
	/// </remarks>
	// Token: 0x02000A59 RID: 2649
	public class vtkHierarchicalBoxDataIterator : vtkUniformGridAMRDataIterator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601BAB4 RID: 113332 RVA: 0x0026BB5B File Offset: 0x00269D5B
		static vtkHierarchicalBoxDataIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHierarchicalBoxDataIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHierarchicalBoxDataIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601BAB5 RID: 113333 RVA: 0x0026BB83 File Offset: 0x00269D83
		public vtkHierarchicalBoxDataIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601BAB6 RID: 113334
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBoxDataIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAB7 RID: 113335 RVA: 0x0026BB94 File Offset: 0x00269D94
		public new static vtkHierarchicalBoxDataIterator New()
		{
			vtkHierarchicalBoxDataIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBoxDataIterator.vtkHierarchicalBoxDataIterator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalBoxDataIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAB8 RID: 113336 RVA: 0x0026BBE8 File Offset: 0x00269DE8
		public vtkHierarchicalBoxDataIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHierarchicalBoxDataIterator.vtkHierarchicalBoxDataIterator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601BAB9 RID: 113337 RVA: 0x0026BC2C File Offset: 0x00269E2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601BABA RID: 113338
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalBoxDataIterator_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BABB RID: 113339 RVA: 0x0026BC38 File Offset: 0x00269E38
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHierarchicalBoxDataIterator.vtkHierarchicalBoxDataIterator_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601BABC RID: 113340
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHierarchicalBoxDataIterator_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BABD RID: 113341 RVA: 0x0026BC58 File Offset: 0x00269E58
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHierarchicalBoxDataIterator.vtkHierarchicalBoxDataIterator_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601BABE RID: 113342
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalBoxDataIterator_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BABF RID: 113343 RVA: 0x0026BC74 File Offset: 0x00269E74
		public override int IsA(string type)
		{
			return vtkHierarchicalBoxDataIterator.vtkHierarchicalBoxDataIterator_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601BAC0 RID: 113344
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHierarchicalBoxDataIterator_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAC1 RID: 113345 RVA: 0x0026BC94 File Offset: 0x00269E94
		public new static int IsTypeOf(string type)
		{
			return vtkHierarchicalBoxDataIterator.vtkHierarchicalBoxDataIterator_IsTypeOf_04(type);
		}

		// Token: 0x0601BAC2 RID: 113346
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBoxDataIterator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAC3 RID: 113347 RVA: 0x0026BCB0 File Offset: 0x00269EB0
		public new vtkHierarchicalBoxDataIterator NewInstance()
		{
			vtkHierarchicalBoxDataIterator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBoxDataIterator.vtkHierarchicalBoxDataIterator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHierarchicalBoxDataIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601BAC4 RID: 113348
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHierarchicalBoxDataIterator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601BAC5 RID: 113349 RVA: 0x0026BD0C File Offset: 0x00269F0C
		public new static vtkHierarchicalBoxDataIterator SafeDownCast(vtkObjectBase o)
		{
			vtkHierarchicalBoxDataIterator vtkHierarchicalBoxDataIterator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHierarchicalBoxDataIterator.vtkHierarchicalBoxDataIterator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalBoxDataIterator = (vtkHierarchicalBoxDataIterator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalBoxDataIterator.Register(null);
				}
			}
			return vtkHierarchicalBoxDataIterator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DA6 RID: 7590
		public new const string MRFullTypeName = "Kitware.VTK.vtkHierarchicalBoxDataIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001DA7 RID: 7591
		public new static readonly string MRClassNameKey = "class vtkHierarchicalBoxDataIterator";
	}
}

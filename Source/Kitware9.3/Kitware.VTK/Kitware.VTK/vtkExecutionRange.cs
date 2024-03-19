using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///  vtkExecutionRange
	/// </summary>
	/// <remarks>
	///  Define a range for the `vtkForEach`.
	///
	/// vtkExecutionRange is an interface used to define the range of a vtkForEach.
	/// It uses the same interface as a vtkAlgorithm because it roles it to split
	/// the execution regarding a given parameter. It can be a timestep, a block ID
	/// or any other parameter.
	///
	/// </remarks>
	/// <seealso>
	///  vtkForEach, vtkEndFor
	/// </seealso>
	// Token: 0x020009CD RID: 2509
	public class vtkExecutionRange : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A2D2 RID: 107218 RVA: 0x00244AFD File Offset: 0x00242CFD
		static vtkExecutionRange()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExecutionRange.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExecutionRange"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A2D3 RID: 107219 RVA: 0x00244B25 File Offset: 0x00242D25
		public vtkExecutionRange(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A2D4 RID: 107220 RVA: 0x00244B33 File Offset: 0x00242D33
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A2D5 RID: 107221
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExecutionRange_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2D6 RID: 107222 RVA: 0x00244B40 File Offset: 0x00242D40
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExecutionRange.vtkExecutionRange_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601A2D7 RID: 107223
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExecutionRange_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2D8 RID: 107224 RVA: 0x00244B60 File Offset: 0x00242D60
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExecutionRange.vtkExecutionRange_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601A2D9 RID: 107225
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutionRange_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2DA RID: 107226 RVA: 0x00244B7C File Offset: 0x00242D7C
		public override int IsA(string type)
		{
			return vtkExecutionRange.vtkExecutionRange_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601A2DB RID: 107227
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExecutionRange_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2DC RID: 107228 RVA: 0x00244B9C File Offset: 0x00242D9C
		public new static int IsTypeOf(string type)
		{
			return vtkExecutionRange.vtkExecutionRange_IsTypeOf_04(type);
		}

		// Token: 0x0601A2DD RID: 107229
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutionRange_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2DE RID: 107230 RVA: 0x00244BB8 File Offset: 0x00242DB8
		public new vtkExecutionRange NewInstance()
		{
			vtkExecutionRange result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutionRange.vtkExecutionRange_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExecutionRange)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A2DF RID: 107231
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExecutionRange_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2E0 RID: 107232 RVA: 0x00244C14 File Offset: 0x00242E14
		public new static vtkExecutionRange SafeDownCast(vtkObjectBase o)
		{
			vtkExecutionRange vtkExecutionRange = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExecutionRange.vtkExecutionRange_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExecutionRange = (vtkExecutionRange)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExecutionRange.Register(null);
				}
			}
			return vtkExecutionRange;
		}

		// Token: 0x0601A2E1 RID: 107233
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkExecutionRange_Size_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A2E2 RID: 107234 RVA: 0x00244C94 File Offset: 0x00242E94
		public virtual ulong Size()
		{
			return vtkExecutionRange.vtkExecutionRange_Size_07(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C67 RID: 7271
		public new const string MRFullTypeName = "Kitware.VTK.vtkExecutionRange";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C68 RID: 7272
		public new static readonly string MRClassNameKey = "class vtkExecutionRange";
	}
}

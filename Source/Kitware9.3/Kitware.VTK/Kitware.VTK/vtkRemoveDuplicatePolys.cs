using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRemoveDuplicatePolys
	/// </summary>
	/// <remarks>
	///    remove duplicate/degenerate polygons
	///
	/// vtkRemoveDuplicatePolys is a filter that removes duplicate or degenerate
	/// polygons. Assumes the input grid does not contain duplicate points. You
	/// may want to run vtkCleanPolyData first to assert it. If duplicated
	/// polygons are found they are removed in the output.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCleanPolyData
	/// </seealso>
	// Token: 0x02000996 RID: 2454
	public class vtkRemoveDuplicatePolys : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060199AB RID: 104875 RVA: 0x00239A1C File Offset: 0x00237C1C
		static vtkRemoveDuplicatePolys()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRemoveDuplicatePolys.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRemoveDuplicatePolys"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060199AC RID: 104876 RVA: 0x00239A44 File Offset: 0x00237C44
		public vtkRemoveDuplicatePolys(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060199AD RID: 104877
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemoveDuplicatePolys_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199AE RID: 104878 RVA: 0x00239A54 File Offset: 0x00237C54
		public new static vtkRemoveDuplicatePolys New()
		{
			vtkRemoveDuplicatePolys result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemoveDuplicatePolys.vtkRemoveDuplicatePolys_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRemoveDuplicatePolys)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199AF RID: 104879 RVA: 0x00239AA8 File Offset: 0x00237CA8
		public vtkRemoveDuplicatePolys() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRemoveDuplicatePolys.vtkRemoveDuplicatePolys_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060199B0 RID: 104880 RVA: 0x00239AEC File Offset: 0x00237CEC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060199B1 RID: 104881
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRemoveDuplicatePolys_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199B2 RID: 104882 RVA: 0x00239AF8 File Offset: 0x00237CF8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRemoveDuplicatePolys.vtkRemoveDuplicatePolys_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060199B3 RID: 104883
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRemoveDuplicatePolys_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199B4 RID: 104884 RVA: 0x00239B18 File Offset: 0x00237D18
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRemoveDuplicatePolys.vtkRemoveDuplicatePolys_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060199B5 RID: 104885
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRemoveDuplicatePolys_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199B6 RID: 104886 RVA: 0x00239B34 File Offset: 0x00237D34
		public override int IsA(string type)
		{
			return vtkRemoveDuplicatePolys.vtkRemoveDuplicatePolys_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060199B7 RID: 104887
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRemoveDuplicatePolys_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199B8 RID: 104888 RVA: 0x00239B54 File Offset: 0x00237D54
		public new static int IsTypeOf(string type)
		{
			return vtkRemoveDuplicatePolys.vtkRemoveDuplicatePolys_IsTypeOf_04(type);
		}

		// Token: 0x060199B9 RID: 104889
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemoveDuplicatePolys_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199BA RID: 104890 RVA: 0x00239B70 File Offset: 0x00237D70
		public new vtkRemoveDuplicatePolys NewInstance()
		{
			vtkRemoveDuplicatePolys result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemoveDuplicatePolys.vtkRemoveDuplicatePolys_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRemoveDuplicatePolys)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060199BB RID: 104891
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemoveDuplicatePolys_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060199BC RID: 104892 RVA: 0x00239BCC File Offset: 0x00237DCC
		public new static vtkRemoveDuplicatePolys SafeDownCast(vtkObjectBase o)
		{
			vtkRemoveDuplicatePolys vtkRemoveDuplicatePolys = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemoveDuplicatePolys.vtkRemoveDuplicatePolys_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRemoveDuplicatePolys = (vtkRemoveDuplicatePolys)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRemoveDuplicatePolys.Register(null);
				}
			}
			return vtkRemoveDuplicatePolys;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BF1 RID: 7153
		public new const string MRFullTypeName = "Kitware.VTK.vtkRemoveDuplicatePolys";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BF2 RID: 7154
		public new static readonly string MRClassNameKey = "class vtkRemoveDuplicatePolys";
	}
}

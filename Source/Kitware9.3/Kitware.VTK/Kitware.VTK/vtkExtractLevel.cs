using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractLevel
	/// </summary>
	/// <remarks>
	///    extract levels between min and max from a
	/// hierarchical box dataset.
	///
	/// vtkExtractLevel filter extracts the levels between (and including) the user
	/// specified min and max levels.
	/// </remarks>
	// Token: 0x020006AD RID: 1709
	public class vtkExtractLevel : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012458 RID: 74840 RVA: 0x00199919 File Offset: 0x00197B19
		static vtkExtractLevel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractLevel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractLevel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012459 RID: 74841 RVA: 0x00199941 File Offset: 0x00197B41
		public vtkExtractLevel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601245A RID: 74842
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractLevel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601245B RID: 74843 RVA: 0x00199950 File Offset: 0x00197B50
		public new static vtkExtractLevel New()
		{
			vtkExtractLevel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractLevel.vtkExtractLevel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractLevel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601245C RID: 74844 RVA: 0x001999A4 File Offset: 0x00197BA4
		public vtkExtractLevel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractLevel.vtkExtractLevel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601245D RID: 74845 RVA: 0x001999E8 File Offset: 0x00197BE8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601245E RID: 74846
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractLevel_AddLevel_01(HandleRef pThis, uint level);

		/// <summary>
		/// Select the levels that should be extracted. All other levels will have no
		/// datasets in them.
		/// </summary>
		// Token: 0x0601245F RID: 74847 RVA: 0x001999F3 File Offset: 0x00197BF3
		public void AddLevel(uint level)
		{
			vtkExtractLevel.vtkExtractLevel_AddLevel_01(base.GetCppThis(), level);
		}

		// Token: 0x06012460 RID: 74848
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractLevel_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012461 RID: 74849 RVA: 0x00199A04 File Offset: 0x00197C04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractLevel.vtkExtractLevel_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06012462 RID: 74850
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractLevel_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012463 RID: 74851 RVA: 0x00199A24 File Offset: 0x00197C24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractLevel.vtkExtractLevel_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06012464 RID: 74852
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractLevel_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012465 RID: 74853 RVA: 0x00199A40 File Offset: 0x00197C40
		public override int IsA(string type)
		{
			return vtkExtractLevel.vtkExtractLevel_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06012466 RID: 74854
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractLevel_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012467 RID: 74855 RVA: 0x00199A60 File Offset: 0x00197C60
		public new static int IsTypeOf(string type)
		{
			return vtkExtractLevel.vtkExtractLevel_IsTypeOf_05(type);
		}

		// Token: 0x06012468 RID: 74856
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractLevel_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012469 RID: 74857 RVA: 0x00199A7C File Offset: 0x00197C7C
		public new vtkExtractLevel NewInstance()
		{
			vtkExtractLevel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractLevel.vtkExtractLevel_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractLevel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601246A RID: 74858
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractLevel_RemoveAllLevels_08(HandleRef pThis);

		/// <summary>
		/// Select the levels that should be extracted. All other levels will have no
		/// datasets in them.
		/// </summary>
		// Token: 0x0601246B RID: 74859 RVA: 0x00199AD6 File Offset: 0x00197CD6
		public void RemoveAllLevels()
		{
			vtkExtractLevel.vtkExtractLevel_RemoveAllLevels_08(base.GetCppThis());
		}

		// Token: 0x0601246C RID: 74860
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractLevel_RemoveLevel_09(HandleRef pThis, uint level);

		/// <summary>
		/// Select the levels that should be extracted. All other levels will have no
		/// datasets in them.
		/// </summary>
		// Token: 0x0601246D RID: 74861 RVA: 0x00199AE5 File Offset: 0x00197CE5
		public void RemoveLevel(uint level)
		{
			vtkExtractLevel.vtkExtractLevel_RemoveLevel_09(base.GetCppThis(), level);
		}

		// Token: 0x0601246E RID: 74862
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractLevel_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601246F RID: 74863 RVA: 0x00199AF8 File Offset: 0x00197CF8
		public new static vtkExtractLevel SafeDownCast(vtkObjectBase o)
		{
			vtkExtractLevel vtkExtractLevel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractLevel.vtkExtractLevel_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractLevel = (vtkExtractLevel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractLevel.Register(null);
				}
			}
			return vtkExtractLevel;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001508 RID: 5384
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractLevel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001509 RID: 5385
		public new static readonly string MRClassNameKey = "class vtkExtractLevel";
	}
}

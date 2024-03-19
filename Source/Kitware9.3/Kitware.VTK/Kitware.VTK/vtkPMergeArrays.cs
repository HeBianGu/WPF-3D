using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPMergeArrays
	/// </summary>
	/// <remarks>
	///    Multiple inputs with one output, parallel version
	///
	/// Like it's super class, this filter tries to combine all arrays from
	/// inputs into one output.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkMergeArrays
	/// </seealso>
	// Token: 0x02000520 RID: 1312
	public class vtkPMergeArrays : vtkMergeArrays
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EAE8 RID: 60136 RVA: 0x0014790B File Offset: 0x00145B0B
		static vtkPMergeArrays()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPMergeArrays.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPMergeArrays"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EAE9 RID: 60137 RVA: 0x00147933 File Offset: 0x00145B33
		public vtkPMergeArrays(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EAEA RID: 60138
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPMergeArrays_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAEB RID: 60139 RVA: 0x00147944 File Offset: 0x00145B44
		public new static vtkPMergeArrays New()
		{
			vtkPMergeArrays result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPMergeArrays.vtkPMergeArrays_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPMergeArrays)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAEC RID: 60140 RVA: 0x00147998 File Offset: 0x00145B98
		public vtkPMergeArrays() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPMergeArrays.vtkPMergeArrays_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EAED RID: 60141 RVA: 0x001479DC File Offset: 0x00145BDC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EAEE RID: 60142
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPMergeArrays_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAEF RID: 60143 RVA: 0x001479E8 File Offset: 0x00145BE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPMergeArrays.vtkPMergeArrays_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600EAF0 RID: 60144
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPMergeArrays_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAF1 RID: 60145 RVA: 0x00147A08 File Offset: 0x00145C08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPMergeArrays.vtkPMergeArrays_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600EAF2 RID: 60146
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPMergeArrays_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAF3 RID: 60147 RVA: 0x00147A24 File Offset: 0x00145C24
		public override int IsA(string type)
		{
			return vtkPMergeArrays.vtkPMergeArrays_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600EAF4 RID: 60148
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPMergeArrays_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAF5 RID: 60149 RVA: 0x00147A44 File Offset: 0x00145C44
		public new static int IsTypeOf(string type)
		{
			return vtkPMergeArrays.vtkPMergeArrays_IsTypeOf_04(type);
		}

		// Token: 0x0600EAF6 RID: 60150
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPMergeArrays_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAF7 RID: 60151 RVA: 0x00147A60 File Offset: 0x00145C60
		public new vtkPMergeArrays NewInstance()
		{
			vtkPMergeArrays result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPMergeArrays.vtkPMergeArrays_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPMergeArrays)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EAF8 RID: 60152
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPMergeArrays_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EAF9 RID: 60153 RVA: 0x00147ABC File Offset: 0x00145CBC
		public new static vtkPMergeArrays SafeDownCast(vtkObjectBase o)
		{
			vtkPMergeArrays vtkPMergeArrays = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPMergeArrays.vtkPMergeArrays_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPMergeArrays = (vtkPMergeArrays)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPMergeArrays.Register(null);
				}
			}
			return vtkPMergeArrays;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400112F RID: 4399
		public new const string MRFullTypeName = "Kitware.VTK.vtkPMergeArrays";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001130 RID: 4400
		public new static readonly string MRClassNameKey = "class vtkPMergeArrays";
	}
}

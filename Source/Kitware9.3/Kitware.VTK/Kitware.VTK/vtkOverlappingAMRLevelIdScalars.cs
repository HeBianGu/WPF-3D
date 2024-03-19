using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOverlappingAMRLevelIdScalars
	/// </summary>
	/// <remarks>
	///    generate scalars from levels.
	///
	/// vtkOverlappingAMRLevelIdScalars is a filter that generates scalars using
	/// the level number for each level. Note that all datasets within a level get
	/// the same scalar. The new scalars array is named \c LevelIdScalars.
	/// </remarks>
	// Token: 0x020008A9 RID: 2217
	public class vtkOverlappingAMRLevelIdScalars : vtkOverlappingAMRAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016FB0 RID: 94128 RVA: 0x00204AFF File Offset: 0x00202CFF
		static vtkOverlappingAMRLevelIdScalars()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOverlappingAMRLevelIdScalars.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOverlappingAMRLevelIdScalars"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016FB1 RID: 94129 RVA: 0x00204B27 File Offset: 0x00202D27
		public vtkOverlappingAMRLevelIdScalars(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016FB2 RID: 94130
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMRLevelIdScalars_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FB3 RID: 94131 RVA: 0x00204B38 File Offset: 0x00202D38
		public new static vtkOverlappingAMRLevelIdScalars New()
		{
			vtkOverlappingAMRLevelIdScalars result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlappingAMRLevelIdScalars.vtkOverlappingAMRLevelIdScalars_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverlappingAMRLevelIdScalars)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FB4 RID: 94132 RVA: 0x00204B8C File Offset: 0x00202D8C
		public vtkOverlappingAMRLevelIdScalars() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOverlappingAMRLevelIdScalars.vtkOverlappingAMRLevelIdScalars_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016FB5 RID: 94133 RVA: 0x00204BD0 File Offset: 0x00202DD0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016FB6 RID: 94134
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOverlappingAMRLevelIdScalars_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FB7 RID: 94135 RVA: 0x00204BDC File Offset: 0x00202DDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOverlappingAMRLevelIdScalars.vtkOverlappingAMRLevelIdScalars_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016FB8 RID: 94136
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOverlappingAMRLevelIdScalars_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FB9 RID: 94137 RVA: 0x00204BFC File Offset: 0x00202DFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOverlappingAMRLevelIdScalars.vtkOverlappingAMRLevelIdScalars_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016FBA RID: 94138
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOverlappingAMRLevelIdScalars_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FBB RID: 94139 RVA: 0x00204C18 File Offset: 0x00202E18
		public override int IsA(string type)
		{
			return vtkOverlappingAMRLevelIdScalars.vtkOverlappingAMRLevelIdScalars_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06016FBC RID: 94140
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOverlappingAMRLevelIdScalars_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FBD RID: 94141 RVA: 0x00204C38 File Offset: 0x00202E38
		public new static int IsTypeOf(string type)
		{
			return vtkOverlappingAMRLevelIdScalars.vtkOverlappingAMRLevelIdScalars_IsTypeOf_04(type);
		}

		// Token: 0x06016FBE RID: 94142
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMRLevelIdScalars_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FBF RID: 94143 RVA: 0x00204C54 File Offset: 0x00202E54
		public new vtkOverlappingAMRLevelIdScalars NewInstance()
		{
			vtkOverlappingAMRLevelIdScalars result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlappingAMRLevelIdScalars.vtkOverlappingAMRLevelIdScalars_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverlappingAMRLevelIdScalars)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016FC0 RID: 94144
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverlappingAMRLevelIdScalars_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016FC1 RID: 94145 RVA: 0x00204CB0 File Offset: 0x00202EB0
		public new static vtkOverlappingAMRLevelIdScalars SafeDownCast(vtkObjectBase o)
		{
			vtkOverlappingAMRLevelIdScalars vtkOverlappingAMRLevelIdScalars = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverlappingAMRLevelIdScalars.vtkOverlappingAMRLevelIdScalars_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverlappingAMRLevelIdScalars = (vtkOverlappingAMRLevelIdScalars)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverlappingAMRLevelIdScalars.Register(null);
				}
			}
			return vtkOverlappingAMRLevelIdScalars;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019B8 RID: 6584
		public new const string MRFullTypeName = "Kitware.VTK.vtkOverlappingAMRLevelIdScalars";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019B9 RID: 6585
		public new static readonly string MRClassNameKey = "class vtkOverlappingAMRLevelIdScalars";
	}
}

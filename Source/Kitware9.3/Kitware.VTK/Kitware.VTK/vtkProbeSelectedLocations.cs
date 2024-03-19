using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkProbeSelectedLocations
	/// </summary>
	/// <remarks>
	///    similar to vtkExtractSelectedLocations
	/// except that it interpolates the point attributes at the probe locations.
	///
	/// vtkProbeSelectedLocations is similar to vtkExtractSelectedLocations except
	/// that it interpolates the point attributes at the probe location. This is
	/// equivalent to the vtkProbeFilter except that the probe locations are provided
	/// by a vtkSelection. The FieldType of the input vtkSelection is immaterial and
	/// is ignored. The ContentType of the input vtkSelection must be
	/// vtkSelection::LOCATIONS.
	/// </remarks>
	// Token: 0x020006C1 RID: 1729
	public class vtkProbeSelectedLocations : vtkExtractSelectionBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012727 RID: 75559 RVA: 0x0019D747 File Offset: 0x0019B947
		static vtkProbeSelectedLocations()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProbeSelectedLocations.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProbeSelectedLocations"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012728 RID: 75560 RVA: 0x0019D76F File Offset: 0x0019B96F
		public vtkProbeSelectedLocations(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012729 RID: 75561
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbeSelectedLocations_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601272A RID: 75562 RVA: 0x0019D780 File Offset: 0x0019B980
		public new static vtkProbeSelectedLocations New()
		{
			vtkProbeSelectedLocations result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbeSelectedLocations.vtkProbeSelectedLocations_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProbeSelectedLocations)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601272B RID: 75563 RVA: 0x0019D7D4 File Offset: 0x0019B9D4
		public vtkProbeSelectedLocations() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkProbeSelectedLocations.vtkProbeSelectedLocations_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601272C RID: 75564 RVA: 0x0019D818 File Offset: 0x0019BA18
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601272D RID: 75565
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProbeSelectedLocations_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601272E RID: 75566 RVA: 0x0019D824 File Offset: 0x0019BA24
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkProbeSelectedLocations.vtkProbeSelectedLocations_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601272F RID: 75567
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkProbeSelectedLocations_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012730 RID: 75568 RVA: 0x0019D844 File Offset: 0x0019BA44
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkProbeSelectedLocations.vtkProbeSelectedLocations_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012731 RID: 75569
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProbeSelectedLocations_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012732 RID: 75570 RVA: 0x0019D860 File Offset: 0x0019BA60
		public override int IsA(string type)
		{
			return vtkProbeSelectedLocations.vtkProbeSelectedLocations_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06012733 RID: 75571
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkProbeSelectedLocations_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012734 RID: 75572 RVA: 0x0019D880 File Offset: 0x0019BA80
		public new static int IsTypeOf(string type)
		{
			return vtkProbeSelectedLocations.vtkProbeSelectedLocations_IsTypeOf_04(type);
		}

		// Token: 0x06012735 RID: 75573
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbeSelectedLocations_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012736 RID: 75574 RVA: 0x0019D89C File Offset: 0x0019BA9C
		public new vtkProbeSelectedLocations NewInstance()
		{
			vtkProbeSelectedLocations result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbeSelectedLocations.vtkProbeSelectedLocations_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProbeSelectedLocations)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012737 RID: 75575
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkProbeSelectedLocations_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012738 RID: 75576 RVA: 0x0019D8F8 File Offset: 0x0019BAF8
		public new static vtkProbeSelectedLocations SafeDownCast(vtkObjectBase o)
		{
			vtkProbeSelectedLocations vtkProbeSelectedLocations = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkProbeSelectedLocations.vtkProbeSelectedLocations_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProbeSelectedLocations = (vtkProbeSelectedLocations)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProbeSelectedLocations.Register(null);
				}
			}
			return vtkProbeSelectedLocations;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001532 RID: 5426
		public new const string MRFullTypeName = "Kitware.VTK.vtkProbeSelectedLocations";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001533 RID: 5427
		public new static readonly string MRClassNameKey = "class vtkProbeSelectedLocations";
	}
}

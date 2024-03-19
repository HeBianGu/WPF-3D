using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageDataToPointSet
	/// </summary>
	/// <remarks>
	///    Converts a vtkImageData to a vtkPointSet
	///
	///
	/// vtkImageDataToPointSet takes a vtkImageData as an image and outputs an
	/// equivalent vtkStructuredGrid (which is a subclass of vtkPointSet).
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// This class was developed by Kenneth Moreland (kmorelndia.gov) from
	/// Sandia National Laboratories.
	/// </seealso>
	// Token: 0x020008AE RID: 2222
	public class vtkImageDataToPointSet : vtkStructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060170BE RID: 94398 RVA: 0x00205E9A File Offset: 0x0020409A
		static vtkImageDataToPointSet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDataToPointSet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDataToPointSet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060170BF RID: 94399 RVA: 0x00205EC2 File Offset: 0x002040C2
		public vtkImageDataToPointSet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060170C0 RID: 94400
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataToPointSet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060170C1 RID: 94401 RVA: 0x00205ED0 File Offset: 0x002040D0
		public new static vtkImageDataToPointSet New()
		{
			vtkImageDataToPointSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataToPointSet.vtkImageDataToPointSet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataToPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060170C2 RID: 94402 RVA: 0x00205F24 File Offset: 0x00204124
		public vtkImageDataToPointSet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageDataToPointSet.vtkImageDataToPointSet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060170C3 RID: 94403 RVA: 0x00205F68 File Offset: 0x00204168
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060170C4 RID: 94404
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDataToPointSet_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060170C5 RID: 94405 RVA: 0x00205F74 File Offset: 0x00204174
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageDataToPointSet.vtkImageDataToPointSet_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060170C6 RID: 94406
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDataToPointSet_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060170C7 RID: 94407 RVA: 0x00205F94 File Offset: 0x00204194
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageDataToPointSet.vtkImageDataToPointSet_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060170C8 RID: 94408
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataToPointSet_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060170C9 RID: 94409 RVA: 0x00205FB0 File Offset: 0x002041B0
		public override int IsA(string type)
		{
			return vtkImageDataToPointSet.vtkImageDataToPointSet_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060170CA RID: 94410
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataToPointSet_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060170CB RID: 94411 RVA: 0x00205FD0 File Offset: 0x002041D0
		public new static int IsTypeOf(string type)
		{
			return vtkImageDataToPointSet.vtkImageDataToPointSet_IsTypeOf_04(type);
		}

		// Token: 0x060170CC RID: 94412
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataToPointSet_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060170CD RID: 94413 RVA: 0x00205FEC File Offset: 0x002041EC
		public new vtkImageDataToPointSet NewInstance()
		{
			vtkImageDataToPointSet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataToPointSet.vtkImageDataToPointSet_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataToPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060170CE RID: 94414
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataToPointSet_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060170CF RID: 94415 RVA: 0x00206048 File Offset: 0x00204248
		public new static vtkImageDataToPointSet SafeDownCast(vtkObjectBase o)
		{
			vtkImageDataToPointSet vtkImageDataToPointSet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataToPointSet.vtkImageDataToPointSet_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDataToPointSet = (vtkImageDataToPointSet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDataToPointSet.Register(null);
				}
			}
			return vtkImageDataToPointSet;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019C2 RID: 6594
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDataToPointSet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019C3 RID: 6595
		public new static readonly string MRClassNameKey = "class vtkImageDataToPointSet";
	}
}

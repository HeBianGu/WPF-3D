using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBlockIdScalars
	/// </summary>
	/// <remarks>
	///    generates scalars from blocks.
	///
	/// vtkBlockIdScalars is a filter that generates scalars using the block index
	/// for each block. Note that all sub-blocks within a block get the same scalar.
	/// The new scalars array is named \c BlockIdScalars.
	/// </remarks>
	// Token: 0x02000876 RID: 2166
	public class vtkBlockIdScalars : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060167A2 RID: 92066 RVA: 0x001F9B67 File Offset: 0x001F7D67
		static vtkBlockIdScalars()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBlockIdScalars.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBlockIdScalars"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060167A3 RID: 92067 RVA: 0x001F9B8F File Offset: 0x001F7D8F
		public vtkBlockIdScalars(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060167A4 RID: 92068
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlockIdScalars_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060167A5 RID: 92069 RVA: 0x001F9BA0 File Offset: 0x001F7DA0
		public new static vtkBlockIdScalars New()
		{
			vtkBlockIdScalars result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlockIdScalars.vtkBlockIdScalars_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlockIdScalars)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060167A6 RID: 92070 RVA: 0x001F9BF4 File Offset: 0x001F7DF4
		public vtkBlockIdScalars() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBlockIdScalars.vtkBlockIdScalars_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060167A7 RID: 92071 RVA: 0x001F9C38 File Offset: 0x001F7E38
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060167A8 RID: 92072
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBlockIdScalars_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060167A9 RID: 92073 RVA: 0x001F9C44 File Offset: 0x001F7E44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBlockIdScalars.vtkBlockIdScalars_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060167AA RID: 92074
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBlockIdScalars_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060167AB RID: 92075 RVA: 0x001F9C64 File Offset: 0x001F7E64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBlockIdScalars.vtkBlockIdScalars_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060167AC RID: 92076
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBlockIdScalars_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060167AD RID: 92077 RVA: 0x001F9C80 File Offset: 0x001F7E80
		public override int IsA(string type)
		{
			return vtkBlockIdScalars.vtkBlockIdScalars_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x060167AE RID: 92078
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBlockIdScalars_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060167AF RID: 92079 RVA: 0x001F9CA0 File Offset: 0x001F7EA0
		public new static int IsTypeOf(string type)
		{
			return vtkBlockIdScalars.vtkBlockIdScalars_IsTypeOf_04(type);
		}

		// Token: 0x060167B0 RID: 92080
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlockIdScalars_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060167B1 RID: 92081 RVA: 0x001F9CBC File Offset: 0x001F7EBC
		public new vtkBlockIdScalars NewInstance()
		{
			vtkBlockIdScalars result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlockIdScalars.vtkBlockIdScalars_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBlockIdScalars)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060167B2 RID: 92082
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBlockIdScalars_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060167B3 RID: 92083 RVA: 0x001F9D18 File Offset: 0x001F7F18
		public new static vtkBlockIdScalars SafeDownCast(vtkObjectBase o)
		{
			vtkBlockIdScalars vtkBlockIdScalars = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBlockIdScalars.vtkBlockIdScalars_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBlockIdScalars = (vtkBlockIdScalars)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBlockIdScalars.Register(null);
				}
			}
			return vtkBlockIdScalars;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001942 RID: 6466
		public new const string MRFullTypeName = "Kitware.VTK.vtkBlockIdScalars";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001943 RID: 6467
		public new static readonly string MRClassNameKey = "class vtkBlockIdScalars";
	}
}
